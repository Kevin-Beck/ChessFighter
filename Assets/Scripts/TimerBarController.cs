using UnityEngine;
using UnityEngine.UI;

public class TimerBarController : MonoBehaviour
{
    public FloatReference cooldown;
    Image bar;
    bool refilling;
    float value;

    private void Awake()
    {
        bar = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
        if (refilling)
        {
            value += Time.deltaTime;
            UpdateBarValue();
        }
    }
    public void UpdateBarValue()
    {
        if(value >= cooldown.Value)
        {
            value = cooldown.Value;
            refilling = false;
        }
        bar.fillAmount = value / cooldown.Value;
    }
    public void StartRefill()
    {
        refilling = true;
        value = 0;
    }
}
