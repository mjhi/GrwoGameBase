using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class BtnManager : MonoBehaviour
{
    public GameObject AttendanceBtn;
    public GameObject BurpPopup;
    public GameObject UpgradePopup;
    public GameObject LevelUpMenu;
    public GameObject BackgroundMenu;
    public GameObject CosteumMenu;
    public GameObject SettingPopup;
    public GameObject TutoPoP;
    public GameObject Tempo;
    public DataManager Data;
    public TabScript TabSC;
    public GameObject popupBack;
    
    // Start is called before the first frame update
    void Start()
    {
        Data = FindObjectOfType<DataManager>();
        TabSC= FindObjectOfType<TabScript>();
        
        popupBack=GameObject.Find("PopUpParent").transform.Find("BackGroundPop").gameObject;
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Tempo.activeSelf==false){
            Tempo.SetActive(true);
        }
    }
    public void ClickAtten()
    {    
	         //클릭 처리       
            print("출석체크!");        
    }
    public void ClickUpgrade()
    {
            Data.NowShowPopUp=UpgradePopup;
            UpgradePopup.SetActive(true);     
            popupBack.SetActive(true); 
    }
    public void ClickBurp()
    {
            Data.NowShowPopUp=BurpPopup;
            BurpPopup.SetActive(true);   
            popupBack.SetActive(true);
    }
    public void LevelUp()
    {
        if(LevelUpMenu.activeSelf==true)
        {
            
            LevelUpMenu.SetActive(false);
            // Data.NowInMenu=GameObject.Find("Temporary");
        }
        else
        {
            Data.NowInMenu.SetActive(false);
            LevelUpMenu.SetActive(true);
            Data.NowInMenu=LevelUpMenu;
        }
    }
    public void ClickBackground()
    {
        if(BackgroundMenu.activeSelf==true)
        {
            
            BackgroundMenu.SetActive(false);
            // Data.NowInMenu=GameObject.Find("Temporary");
        }
        else
        {
            Data.NowInMenu.SetActive(false);
            BackgroundMenu.SetActive(true);
            Data.NowInMenu=BackgroundMenu;
        }

        
    }
    public void ClickCosteum()
    {
        if(CosteumMenu.activeSelf==true)
        {
            CosteumMenu.SetActive(false);
            // Data.NowInMenu=GameObject.Find("Temporary");
        }
        else
        {
            Data.NowInMenu.SetActive(false);
            CosteumMenu.SetActive(true);
            Data.NowInMenu=CosteumMenu;
        }

        
    }
    public void ClosePOP()
    {
        Data.NowShowPopUp.SetActive(false);
        Data.NowShowPopUp=GameObject.Find("Temporary");
        Data.NowInMenu=GameObject.Find("Temporary");
        popupBack.SetActive(false);
    }
    
    public void AutoCancel()
    {
        CancelInvoke("AutoSeed");
    }

    public void ClickSetting()
    {
        
        SettingPopup.SetActive(true);
        Data.NowShowPopUp=SettingPopup;
        popupBack.SetActive(true);    
    }
    
    public void NameSET()
    {
        Data.SetName();
        TutoPoP.SetActive(false);
    }
    
}
