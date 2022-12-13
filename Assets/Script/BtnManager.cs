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
    public DataManager Data;
    // Start is called before the first frame update
    void Start()
    {
        Data = FindObjectOfType<DataManager>();
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
        if(UpgradePopup.activeSelf==true){
            UpgradePopup.SetActive(false);
        }
        else{
            Data.NowShowPopUp.SetActive(false);
            UpgradePopup.SetActive(true);
            Data.NowShowPopUp=UpgradePopup;
        }
        
    }
    public void ClickBurp()
    {
        if(BurpPopup.activeSelf==true){
            BurpPopup.SetActive(false);
        }
        else{
            Data.NowShowPopUp.SetActive(false);
            BurpPopup.SetActive(true);
            Data.NowShowPopUp=BurpPopup;
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
}

