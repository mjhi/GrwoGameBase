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
    public DataManager Data;
    public TabScript TabSC;
    // Start is called before the first frame update
    void Start()
    {
        Data = FindObjectOfType<DataManager>();
        TabSC= FindObjectOfType<TabScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickAtten()
    {
        if(EventSystem.current.IsPointerOverGameObject())
	    {  
	         //클릭 처리
            
            print("출석체크!");

	    }
        
 
	         
    }
    public void ClickUpgrade()
    {
        if(EventSystem.current.IsPointerOverGameObject())
	    {  
	         //클릭 처리
            
            Data.NowShowPopUp=UpgradePopup;
            UpgradePopup.SetActive(true);

	    }
        
            
            
    }
        
    
    public void ClickBurp()
    {
        if(EventSystem.current.IsPointerOverGameObject())
	    {  
	         //클릭 처리
            
            Data.NowShowPopUp=BurpPopup;
            BurpPopup.SetActive(true);

	    }
            
        
        
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
        
    }

}
