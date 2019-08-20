using UnityEngine;

public class Attack : MonoBehaviour
{
    bool canAttack = true;
    public FloatReference attackCooldown;
    public GameEvent attacked;
    public GameObject bullet;
    public float bulletSpeed;

    public void AttackTowards(Vector3 direction)
    {
        if (canAttack)
        {
            GameObject go = Instantiate(bullet, transform.position + new Vector3(0, .1f, 0) + direction, Quaternion.identity);
            go.GetComponent<Rigidbody>().AddForce(direction * bulletSpeed);
            canAttack = false;
            attacked.Raise();
            Invoke("ResetMoveCooldown", attackCooldown.Value);
        }
    }
    private void ResetMoveCooldown()
    {
        canAttack = true;
    }
}
