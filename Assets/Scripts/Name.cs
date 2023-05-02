using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public string nameOfPlayer;
    public string saveName;
    public Text Output;

    public Text inputText;

    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "none");
    }

    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
    }
}