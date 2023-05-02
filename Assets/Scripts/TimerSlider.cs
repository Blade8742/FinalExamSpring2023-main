using UnityEngine;
using UnityEngine.UI;
public class TimerSlider : MonoBehaviour
{
    public Slider Timerslider;
    public Text TimerText;
    public static float Timerspeed;
    public float timer;
    public Text time;

    public void slide ()
    {
        Timerspeed = Timerslider.value;
        TimerText.text = Timerspeed.ToString("f0");
    }
    public void Update()
    {
        if (timer != 0)
        {
        timer -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(timer % 60.0f);
        time.text = seconds.ToString();
        }
    }
}
