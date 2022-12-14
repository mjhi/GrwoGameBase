using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterSC : MonoBehaviour
{
    public GameObject Seed;
    public Transform spawnPosition;
    public Animator animator;
    public bool EatBool;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EatBool){
            animator.SetTrigger("Eat");
            EatBool=false;   
        }

    }
    void OnMouseDown() {
        Instantiate(Seed,spawnPosition.position,spawnPosition.rotation);   
    }

}
