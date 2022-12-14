using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIListitem : MonoBehaviour
{
    
    public Image icon;
    public Text Description;
    public Text Name;
    public Text Price;
    public void Init(Sprite sp,string Des,string Na,int price)
    {
        icon.sprite = sp;
        Description.text=Des;
        Name.text=Na;
        Price.text=price.ToString();
    }
}
