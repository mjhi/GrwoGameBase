using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBtnManager : MonoBehaviour
{
    public GameObject AccessoriesShop;
    public GameObject DressShop;
    public GameObject HairShop;
    public GameObject HatShop;
    public GameObject NowCosteumShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickAccessories()
    {
        if(AccessoriesShop.activeSelf==true)
        {
            AccessoriesShop.SetActive(false);
        }
        else{
            NowCosteumShow.SetActive(false);
            AccessoriesShop.SetActive(true);
            NowCosteumShow=AccessoriesShop;
        }
    }
    public void ClickDress()
    {
        if(DressShop.activeSelf==true)
        {
            DressShop.SetActive(false);
        }
        else{
            NowCosteumShow.SetActive(false);
            DressShop.SetActive(true);
            NowCosteumShow=DressShop;
        }

    }
    public void ClickHair()
    {
        if(HairShop.activeSelf==true)
        {
            HairShop.SetActive(false);
        }
        else{
            NowCosteumShow.SetActive(false);
            HairShop.SetActive(true);
            NowCosteumShow=HairShop;
        }

    }
    public void ClickHat()
    {
        if(HatShop.activeSelf==true)
        {
            HatShop.SetActive(false);
        }
        else{
            NowCosteumShow.SetActive(false);
            HatShop.SetActive(true);
            NowCosteumShow=HatShop;
        }

    }
}
