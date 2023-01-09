using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHairShop : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    ItemInfo[] HairShop;
    public GameObject contents;
    public GameObject uiListItemPrefab;
    public float iconWidth=140;
    public float iconHeight=140;
    
    // Start is called before the first frame update
    void Start()
    {
       WWW();
        
    }
    void WWW()
    {
        HairShop = itemSO.HairShopInfo;
        for(int i=0; i<HairShop.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(HairShop[i].icon,HairShop[i].Description,HairShop[i].name,HairShop[i].price);
        }
    }
}
