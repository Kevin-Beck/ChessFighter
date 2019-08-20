using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    bool canMove = true;
    public FloatReference moveCooldown;
    public GameEvent moved;
    public GameEvent died;
    public GameObject Board;


    private void ResetMoveCooldown()
    {
        canMove = true;
    }

    public void MoveNorth()
    {
        if (canMove)
        {
            transform.position += transform.forward;
            canMove = false;
            CheckBounds();
            Invoke("ResetMoveCooldown", moveCooldown);
            moved.Raise();
        }
    }
    public void MoveSouth()
    {
        if(canMove)
        {
            transform.position += transform.forward * -1;
            canMove = false;
            CheckBounds();
            Invoke("ResetMoveCooldown", moveCooldown);
            moved.Raise();
        }
    }
    public void MoveEast()
    {
        if (canMove)
        {
            transform.position += transform.right;
            canMove = false;
            CheckBounds();
            Invoke("ResetMoveCooldown", moveCooldown);
            moved.Raise();
        }
    }
    public void MoveWest()
    {
        if (canMove)
        {
            transform.position += transform.right * -1;
            canMove = false;
            CheckBounds();
            Invoke("ResetMoveCooldown", moveCooldown);
            moved.Raise();
        }
    }

    private void CheckBounds()
    {
        if (transform.position.x > Board.transform.localScale.x || transform.position.z > Board.transform.localScale.z || transform.position.x < 0 || transform.position.z < 0)
        {
            died.Raise();
        }
    }
}
