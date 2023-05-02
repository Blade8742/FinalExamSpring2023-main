using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameS1 : MonoBehaviour
{
    public Text NameLoaded;
    public void Awake()
    {
        string name1 = PlayerPrefs.GetString("name");
        NameLoaded.text = "Currently Playing: " + name1;
    }
}
