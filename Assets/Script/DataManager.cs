using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Text SeedCountObject;
    public int SeedCount;
    public int MaxSeed;
    public GameObject NowShowPopUp;
    public GameObject NowInMenu;
    public bool LevelUpBool=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SeedCountObject.text=SeedCount.ToString()+"/"+MaxSeed.ToString();
        if(SeedCount>MaxSeed){
            SeedCount-=1;
            LevelUpBool=true;
        }
    }
}
