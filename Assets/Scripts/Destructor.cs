using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    public GameEvent BlockDestroyed;

    private void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Obstacle")
        {
            Destroy(c.gameObject);
            BlockDestroyed.Raise();
            Destroy(gameObject);
        }     
    }
}
