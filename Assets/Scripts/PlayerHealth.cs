using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public FloatReference MaxHealth;
    public FloatVariable CurHealth;
    public GameEvent HPchanged;
    public GameEvent PlayerDeath;

    private void Start()
    {
        CurHealth.SetValue(MaxHealth.Value);
        HPchanged.Raise();
    }
    private void OnCollisionEnter(Collision collision)
    {
        TakeDamage(collision.relativeVelocity.magnitude*5);
    }
    public void TakeDamage(float val)
    {
        CurHealth.SetValue(CurHealth.Value - val);
        HPchanged.Raise();
        if (CurHealth.Value <= 0)
            PlayerDeath.Raise();
    }
}
