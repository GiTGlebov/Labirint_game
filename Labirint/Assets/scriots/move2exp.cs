using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2exp : MonoBehaviour
{
    public float speed;
    int time = 1;
    void Update()
    {
        transform.Translate(new Vector2(1, 0) * Time.deltaTime);
    }

   
}
