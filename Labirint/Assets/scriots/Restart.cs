using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public bool restarting = false;
    public Restart player;
    private void OnTriggerEnter2D(Collider2D person)
    {
        if (!restarting && person.gameObject.name.Equals("character"))
        {
            player.restarting = true;
            player.transform.position = new Vector2(-10.64f, -3.27f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        restarting = false;
    }
}
