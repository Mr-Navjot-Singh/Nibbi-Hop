using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public static int health;
    public bool isCatDied = false;
    Timer timer;
    private void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        if(health >= 0)
        {
            slider.value = health;
        }
        if(health == 0 && timer.myTime>2)
        {
            isCatDied = true;
        }
        Debug.Log("-------Health bar: " + health);

    }
}
