using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    DateTime t= DateTime.Now;
    DateTime StartTime;
    public GameObject AdBlock;
    public BurfScript BurfSC ;
    public Text leftText;
    public TimeSpan GAP;
    public DataManager Data;
    public DateTime BurfLastTime;
    public bool Ad;
    // Start is called before the first frame update
    void Start()
    {
        BurfSC = FindObjectOfType<BurfScript>();
        Data = FindObjectOfType<DataManager>();
        bool IsSave = PlayerPrefs.HasKey("saved_game");
        if(!IsSave){
            Ad=false;
            BurfSC.AutoBurfCK=false;
            BurfSC.DoubleBurfCK=false;
        }
        else{
            Ad=Convert.ToBoolean(PlayerPrefs.GetInt("AdBool"));
            StartTime=DateTime.Parse(PlayerPrefs.GetString("StartTime"));
            BurfLastTime=DateTime.Parse(PlayerPrefs.GetString("BurfLastTime"));
            BurfSC.AutoBurfCK=Convert.ToBoolean(PlayerPrefs.GetInt("AutoBurfBool"));
            BurfSC.DoubleBurfCK=Convert.ToBoolean(PlayerPrefs.GetInt("DoubleBurfBool"));
            if(BurfSC.AutoBurfCK){
                t=DateTime.Now;
                GAP = t-BurfLastTime;
                Data.SeedCount+=Convert.ToInt32(GAP.TotalSeconds);
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        GAP = t-StartTime;
        int LeftTimeSecond = 60-Int32.Parse(GAP.ToString("ss"));
        int LeftTimeMinute = 9-Int32.Parse(GAP.ToString("mm"));
        t=DateTime.Now;
        leftText.text = LeftTimeMinute.ToString()+"분"+LeftTimeSecond.ToString()+"초";
        if(Ad){
            AdBlock.SetActive(true);
            if(GAP.TotalSeconds>615){
                if(BurfSC.AutoBurfCK)
                {
                    BurfSC.AutoBurfCK=false;
                }
                else if(BurfSC.DoubleBurfCK)
                {
                    BurfSC.SeedCountPWDown();
                }
                AdBlock.SetActive(false); 
                Ad=false;
            }
            
        }
    }
    public void AdTime()
    {
        StartTime=t;
        
        Ad=true;
    }
    void OnApplicationQuit(){
       PlayerPrefs.SetInt("AdBool",Convert.ToInt32(Ad));
       PlayerPrefs.SetInt("AutoBurfBool",Convert.ToInt32(BurfSC.AutoBurfCK));
       PlayerPrefs.SetInt("DoubleBurfBool",Convert.ToInt32(BurfSC.DoubleBurfCK));
       PlayerPrefs.SetString("StartTime",StartTime.ToString());
       PlayerPrefs.SetString("BurfLastTime",t.ToString());
    }
}
