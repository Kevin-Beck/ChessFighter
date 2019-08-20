using UnityEngine;

public class click : MonoBehaviour
{
    bool canAttack = true;
    public GameEvent attacked;
    public FloatReference attackcd;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void ResetAttackCooldown()
    {
        canAttack = true;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            canAttack = false;
            attacked.Raise();
            Invoke("ResetAttackCooldown", attackcd.Value);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 100.0f);
            if(hit.collider.gameObject.tag == "Player")
            {
                hit.collider.gameObject.GetComponent<PlayerHealth>().TakeDamage(Random.Range(3f, 15f));
            }
        }
    }
}
