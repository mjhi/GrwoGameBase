using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    bool IsSave;
    public InputField PlayerInputName;
    public Text SeedCountObject;
    public Text PlayerName;
    public int SeedCount;
    public int MaxSeed;
    public int SeedCountPW;
    public string PrName;
    public GameObject NowShowPopUp;
    public GameObject NowInMenu;
    public GameObject UpbackGround;
    public bool LevelUpBool=false;
    public GameObject TutoPoP;
    // Start is called before the first frame update
    void Start()
    {
        UpbackGround=GameObject.Find("PopUpParent").transform.Find("BackGroundPop").gameObject;
        
        IsSave = PlayerPrefs.HasKey("saved_game");
        if(!IsSave)
        {
            TutoPoP.SetActive(true);
            SeedCount=0;
            MaxSeed=1000;
            NowShowPopUp=GameObject.Find("Temporary");
            NowInMenu=GameObject.Find("Temporary");
            LevelUpBool=false;
            SeedCountPW=1;
        }
        else{
            SeedCountPW=PlayerPrefs.GetInt("SeedCountPW");
            PrName=PlayerPrefs.GetString("name");
            SeedCount=PlayerPrefs.GetInt("SeedCount");
            MaxSeed=PlayerPrefs.GetInt("MaxCount");

            
            
            
            string a = PlayerPrefs.GetString("PopUp");
            if(a!="Temporary"){
                
                a=GameObject.Find("PopUpParent").transform.Find(a).gameObject.name;
                GameObject.Find("PopUpParent").transform.Find(a).gameObject.SetActive(true);
                UpbackGround.SetActive(true);
            }
            string b = PlayerPrefs.GetString("Menu");
            print(b);
            if(b!="Temporary"){
                
                //  b=GameObject.Find("PopUpParent").transform.Find(b).gameObject.name;
                // string  imsi = GameObject.Find("PopUpParent").transform.Find("SeedPopup").gameObject.name;
                GameObject.Find(a).transform.Find(b).gameObject.SetActive(true);
                UpbackGround.SetActive(true);
            }
            
            
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
        PlayerPrefs.SetString("name",PrName);
        PlayerPrefs.SetInt("saved_game",1);
        PlayerPrefs.SetInt("SeedCount",SeedCount);
        PlayerPrefs.SetInt("MaxCount",MaxSeed);
        PlayerPrefs.SetInt("LevelUp",System.Convert.ToInt16(LevelUpBool));
        
        PlayerPrefs.SetString("PopUp",NowShowPopUp.name);
        PlayerPrefs.SetString("Menu",NowInMenu.name);
        PlayerPrefs.SetInt("SeedCountPW",SeedCountPW);
    }
    public void SetName()
    {
        PrName=PlayerInputName.text;
    }
}
