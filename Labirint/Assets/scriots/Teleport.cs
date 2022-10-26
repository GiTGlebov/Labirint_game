using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public bool teleported=false;
    public Teleport target;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!teleported)
        {
            target.teleported = true;
            other.transform.position = target.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        teleported = false;
    }
}
