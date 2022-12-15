using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedScript : MonoBehaviour
{
    public DataManager Data;
    public HamsterSC HamSC;
    
    // public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        Data = FindObjectOfType<DataManager>();
        HamSC = FindObjectOfType<HamsterSC>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            Data.SeedCount+=Data.SeedCountPW;
            Destroy(gameObject);
            HamSC.EatBool=true;
            // animator.SetBool("Eat",true);
            
        }
       
    }
}
