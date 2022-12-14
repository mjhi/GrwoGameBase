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
    public ItemInfo[] CosteumItem;
}
