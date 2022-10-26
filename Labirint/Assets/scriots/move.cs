using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour { 
    public float speed= 3f;
   Vector2 movementdir;
    Animator anim;
    float vertical;

    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        if (vertical==0)
        {
            anim.SetBool("walk", false);
        }
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
           if (input.x !=0)
        {
            movementdir.Set(input.x, 0f);
            anim.SetBool("walk", true);
        }
           else if(input.y !=0)
        {
            movementdir.Set(0f, input.y);
            anim.SetBool("walk", true);
        }
           else if(input==Vector2.zero)
        {
            movementdir = Vector2.zero;
        }
           else if(input.x !=0 && input.y !=0)
        {
            movementdir.Set(input.x, input.y);
        }
        transform.position += (Vector3)movementdir * speed * Time.deltaTime;
    }
}
