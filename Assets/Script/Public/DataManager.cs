using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    bool IsSave;
    public Text SeedCountObject;
    public Text PlayerName;
    public int SeedCount;
    public int MaxSeed;
    public int SeedCountPW=1;
    public string PrName;
    public GameObject NowShowPopUp;
    public GameObject NowInMenu;
    public bool LevelUpBool=false;
    // Start is called before the first frame update
    void Start()
    {
        PrName=PlayerPrefs.GetString("name");
        IsSave = PlayerPrefs.HasKey("saved_game");
        if(!IsSave)
        {
            SeedCount=0;
            MaxSeed=1000;
            NowShowPopUp=GameObject.Find("Temporary");
            NowInMenu=GameObject.Find("Temporary");
            LevelUpBool=false;
        }
        else{
            SeedCount=PlayerPrefs.GetInt("SeedCount");
            MaxSeed=PlayerPrefs.GetInt("MaxCount");

            string a = PlayerPrefs.GetString("PopUp");
            string b = PlayerPrefs.GetString("Menu");
            NowShowPopUp=GameObject.Find(a);
            NowInMenu=GameObject.Find(b);

            int LevelUpbool = PlayerPrefs.GetInt("LevelUp");
            LevelUpBool=System.Convert.ToBoolean(LevelUpbool);

        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName.text=PrName;
        SeedCountObject.text=SeedCount.ToString()+"/"+MaxSeed.ToString();
        if(SeedCount>MaxSeed){
            SeedCount-=1;
            LevelUpBool=true;
        }
    }
    void OnApplicationQuit(){
        PlayerPrefs.SetInt("saved_game",1);
        PlayerPrefs.SetInt("SeedCount",SeedCount);
        PlayerPrefs.SetInt("MaxCount",MaxSeed);
        PlayerPrefs.SetInt("LevelUp",System.Convert.ToInt16(LevelUpBool));

        PlayerPrefs.SetString("PopUp",NowShowPopUp.name);
        PlayerPrefs.SetString("Menu",NowInMenu.name);
    }
}
