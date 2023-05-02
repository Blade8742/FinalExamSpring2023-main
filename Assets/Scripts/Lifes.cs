using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public int amount;
    public Dropdown lifes;
    public void changelifes()
    {
    amount = lifes.value;
    PlayerPrefs.SetInt("amount1", amount);   
    }
}
