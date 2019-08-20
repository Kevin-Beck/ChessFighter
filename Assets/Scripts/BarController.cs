using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    public FloatReference maxVal;
    public FloatReference curVal;
    Image bar;

    private void Awake()
    {
        bar = GetComponent<Image>();   
    }
    public void UpdateBarValue()
    {
        bar.fillAmount = curVal.Value / maxVal.Value;
    }
}
