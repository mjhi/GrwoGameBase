using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
public class UIShopBackground : MonoBehaviour
{

    [SerializeField] ItemSO itemSO;

    ItemInfo[] Background;
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
        Background = itemSO.BackgroundItem;
        for(int i=0; i<Background.Length; i++){
            var go = Instantiate<GameObject>(this.uiListItemPrefab, contents.transform);
            var UIListitem = go.GetComponent<UIListitem>();
            UIListitem.Init(Background[i].icon,Background[i].Description,Background[i].name,Background[i].price);
        }
    }


}
