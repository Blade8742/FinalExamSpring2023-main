using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bothpoints : MonoBehaviour
{
    public Button decrease;
    public Button increase;
    public Text points;
    public static int point;
    public void Decrease()
    {
        if (point != 0)
        {
            point = point - 1;
        }
    }
    public void Increase()
    {
            point = point + 1;
    }
    public void Update()
    {
        points.text = point.ToString();
    }
}
