using UnityEngine;

[RequireComponent(typeof(Move))]
[RequireComponent(typeof(Attack))]
public class PlayerInput : MonoBehaviour
{
    Move myMove;
    Attack myAttack;

    private void Awake()
    {
        myMove = GetComponent<Move>();
        myAttack = GetComponent<Attack>();
    }
    
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                myMove.MoveNorth();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                myMove.MoveEast();
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                myMove.MoveSouth();
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                myMove.MoveWest();
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                myAttack.AttackTowards(transform.right * -1);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                myAttack.AttackTowards(transform.forward);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                myAttack.AttackTowards(transform.right);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                myAttack.AttackTowards(transform.forward * -1);
            }
        }
    }
}
