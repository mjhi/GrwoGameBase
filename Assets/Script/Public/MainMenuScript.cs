using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            int pointerID;
            #if UNITY_EDITOR
            pointerID = -1; //PC나 유니티 상에서는 -1
            #elif UNITY_IOS || UNITY_IPHONE
            pointerID = 0;  // 휴대폰이나 이외에서 터치 상에서는 0 
            #endif

            
                SceneManager.LoadScene("Main");
           
            
            
	        
        }
    }
}
