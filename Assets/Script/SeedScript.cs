using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedScript : MonoBehaviour
{
    public DataManager Data;
    // Start is called before the first frame update
    void Start()
    {
        Data = FindObjectOfType<DataManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            Data.SeedCount+=1;
            print("닿아버렷");
            Destroy(gameObject);
        }
    }
}
