using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TabScript : MonoBehaviour
{
    
    public GameObject Seed;
    public Transform spawnPosition;

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
	        if(!EventSystem.current.IsPointerOverGameObject(pointerID))
	        {  
	         //클릭 처리
             Instantiate(Seed,spawnPosition.position,spawnPosition.rotation);

	        }
        }
    }
}
