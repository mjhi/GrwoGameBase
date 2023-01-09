using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurfScript : MonoBehaviour
{
    
    
    public TimeManager Time;
    public DataManager Data;
    public bool AutoBurfCK;
    public bool DoubleBurfCK;
    public TabScript TabSC;
    // Start is called before the first frame update
    void Start()
    {
        Time = FindObjectOfType<TimeManager>();
        Data = FindObjectOfType<DataManager>();
        TabSC= FindObjectOfType<TabScript>();
        if(AutoBurfCK)
        {
            AutoSeed();
        }
    }
    void Update()
    {
    }
    public void SeedCountPWDown()
    {
        Data.SeedCountPW/=2;
    }
    public void AutoSeed()
    {
        if(AutoBurfCK){
            TabSC.SeedDrop();
            Invoke("AutoSeed",1f);
        }
        
    }
    public void InBurpClick()
    {
        Time.AdTime();
    }
    // Update is called once per frame
    
    public void AutoBurf()
    {
        AutoBurfCK=true;
        Invoke("AutoSeed",1f);
    }
    public void DoubleBurf()
    {
        Data.SeedCountPW*=2;   
    }
}
