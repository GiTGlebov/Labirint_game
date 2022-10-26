using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeeZone : MonoBehaviour
   
{
   public GameObject bat;
    private int  speed=1;
    private Vector3 target;
    private Vector3 target1;
    private Vector3 target2;
    private Vector3 target3;
    bool agressive=false;
    private void Start()
    {
        target.x = -2.7f;
        target.y = bat.transform.position.y;
        target2 = target;
        target1.x = bat.transform.position.x;
        target1.y = bat.transform.position.y;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        agressive = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("character"))
        {
            bat.transform.position = Vector3.MoveTowards(bat.transform.position, target2, Time.deltaTime * speed);
        }
        if (bat.transform.position == target2) { target2 = target1; }
        if (bat.transform.position == target1) { target2 = target; }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        agressive = false;
    }
    private void Update()
    {
        if(!agressive)
        {
            bat.transform.position = Vector3.MoveTowards(bat.transform.position, target1, Time.deltaTime * speed);
        }
    }

}

