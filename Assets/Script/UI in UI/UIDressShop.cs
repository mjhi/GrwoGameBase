using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDressShop : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    ItemInfo[] DressShop;
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
        DressShop = itemSO.DressShopInfo;
        for(int i=0; i<DressShop.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(DressShop[i].icon,DressShop[i].Description,DressShop[i].name,DressShop[i].price);
        }
    }
}
