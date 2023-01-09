using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelUpShop : MonoBehaviour
{
    [SerializeField] ItemSO itemSO;

    ItemInfo[] LevelUpShop;
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
        LevelUpShop = itemSO.LevelUpShopInfo;
        for(int i=0; i<LevelUpShop.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(LevelUpShop[i].icon,LevelUpShop[i].Description,LevelUpShop[i].name,LevelUpShop[i].price);
        }
    }
}
