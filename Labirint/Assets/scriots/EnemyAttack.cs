using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public bool atacked = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("character"))
        {
            atacked = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("character") && atacked)
        {
            Debug.Log("GameOver");
            player.transform.position = new Vector2(-10.64f, -3.27f);
            Debug.Log("GameOver");
        }
    }
    
}
