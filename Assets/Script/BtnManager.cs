using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class BtnManager : MonoBehaviour
{
    public GameObject AttendanceBtn;
    public GameObject BurpBtn;
    public GameObject UpgradePopup;
    public GameObject BurpPopup;
    public GameObject BackgroundMenu;
    public GameObject CosteumMenu;
    public GameObject SettingPopup;
    public GameObject Tempo;
    public DataManager Data;
    public TabScript TabSC;
    public void SeedCountPWDown()
    {
        Data.SeedCountPW/=2;
    }
    // Start is called before the first frame update
    void Start()
    {
        Data = FindObjectOfType<DataManager>();
        TabSC= FindObjectOfType<TabScript>();
    
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
        
	         //클릭 처리
            
            Data.NowShowPopUp=UpgradePopup;
            UpgradePopup.SetActive(true);

	    
        
            
            
    }
    public void ClickBurp()
    {
        
	         //클릭 처리
            
            Data.NowShowPopUp=BurpPopup;
            BurpPopup.SetActive(true);

	    
            
        
        
    }
    public void LevelUp()
    {
        if(Data.LevelUpBool){
            if(Data.SeedCount!=100000){
                Data.MaxSeed*=2;
                Data.SeedCount=0;
            }
            
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
    }
    public void AutoSeed()
    {
        TabSC.SeedDrop();
    }
    public void AutoCancel()
    {
        CancelInvoke("AutoSeed");
    }
    public void AutoBurf()
    {
        
        InvokeRepeating("AutoSeed", 1, 1f);
        Invoke("AutoCancel",60f);
        
        
    }
    public void DoubleBurf()
    {
        Data.SeedCountPW*=2;
        Invoke("SeedCountPWDown",60);
    }
    public void ClickSetting()
    {
        Data.NowShowPopUp.SetActive(false);
        SettingPopup.SetActive(true);
        Data.NowShowPopUp=SettingPopup;
        
        
    }
}
