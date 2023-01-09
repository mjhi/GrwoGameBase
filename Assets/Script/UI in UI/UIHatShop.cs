using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHatShop : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    ItemInfo[] HatShop;
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
        HatShop = itemSO.HatShopInfo;
        for(int i=0; i<HatShop.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(HatShop[i].icon,HatShop[i].Description,HatShop[i].name,HatShop[i].price);
        }
    }
}
