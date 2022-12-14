using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
public class UIShopCosteum : MonoBehaviour
{

    [SerializeField] ItemSO itemSO;

    ItemInfo[] Costeum;
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
        Costeum = itemSO.CosteumItem;
        for(int i=0; i<Costeum.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(Costeum[i].icon,Costeum[i].Description,Costeum[i].name,Costeum[i].price);
        }
    }


}
