using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bothlive : MonoBehaviour
{
    public Button decrease;
    public Button increase;
    public Text lives;
    public static int amount2;
    public void Awake()
    {
    int livestext = PlayerPrefs.GetInt("amount1");
    amount2 = livestext;
    }
    public void Decrease()
    {
        if (amount2 != 0)
        {
            amount2 = amount2 - 1;
        }
    }
    public void Increase()
    {
            amount2 = amount2 + 1;
    }
    public void Update()
    {
        lives.text = amount2.ToString();
    }
}
