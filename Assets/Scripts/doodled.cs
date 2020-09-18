using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodled : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            anim.SetBool("doodled", true);
        }
    }
}
