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
        
    }
    void OnMouseDown()
    {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                Instantiate(Seed,spawnPosition.position,spawnPosition.rotation);
                print("레츠고세구");
            }    
    }
}
