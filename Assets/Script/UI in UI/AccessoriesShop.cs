using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
public class AccessoriesShop : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    ItemInfo[] Accessories;
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
        Accessories = itemSO.AccessoriesShopInfo;
        for(int i=0; i<Accessories.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(Accessories[i].icon,Accessories[i].Description,Accessories[i].name,Accessories[i].price);
        }
    }
}
