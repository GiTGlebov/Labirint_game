using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapcircle : MonoBehaviour
{
    Vector2 dvij;
    public float speed=3f;
    private float realspeed;
    private bool konecdvij=false;
    private int sec=0;
     public Vector3 target;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y!=-3.37f)
        {
            target.y=-3.37f;
        }
        else if (transform.position == target && target.y == -3.37f)
        {
            target.y = -1.5f;
        }
    }
}
