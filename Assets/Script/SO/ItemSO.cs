using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [System.Serializable]
public class ItemInfo
{
    public string name;
    public int price;
    public string Description;
    public Sprite icon;
}
[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/ItemSO")]

public class ItemSO : ScriptableObject
{
    public ItemInfo[] BackgroundItem;
    public ItemInfo[] AccessoriesShopInfo;
    public ItemInfo[] DressShopInfo;
    public ItemInfo[] HairShopInfo;
    public ItemInfo[] HatShopInfo;
    public ItemInfo[] LevelUpShopInfo;
}
