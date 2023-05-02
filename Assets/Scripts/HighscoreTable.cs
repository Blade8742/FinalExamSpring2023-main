using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class HighscoreTable : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;
    private List<HighscoreEntry> highscoreEntryList;
    private List<Transform> highscoreEntryTransformList;

    private void Awake()
    {
        int score1 = PlayerPrefs.GetInt("CScore");
        string name1 = PlayerPrefs.GetString("name");
        entryContainer = transform.Find("highscoreEntryContainer");
        entryTemplate = entryContainer.Find("highscoreEntryTemplate");
        entryTemplate.gameObject.SetActive(false);

        highscoreEntryList = new List<HighscoreEntry>()
        {
             new HighscoreEntry{score = 700, name = "John" },
             new HighscoreEntry{score = 800, name = "Tim" },
             new HighscoreEntry{score = 300, name = "Ferb" },
             new HighscoreEntry{score = 400, name = "Michael" },
             new HighscoreEntry{score = 500, name = "Tommy" },
             new HighscoreEntry{score = 1100, name = "Kadyn" },
             new HighscoreEntry{score = 1200, name = "Jeff" },
             new HighscoreEntry{score = 1500, name = "Ryan" },
             new HighscoreEntry{score = score1, name =  name1},
             new HighscoreEntry{score = 900, name = "Tonny" },
        };

        for (int i = 0; i < highscoreEntryList.Count; i++)
        {
            for (int j = i + 1; j < highscoreEntryList.Count; j++)
            {
                if (highscoreEntryList[j].score > highscoreEntryList[i].score)
                {
                    HighscoreEntry tmp = highscoreEntryList[i];
                    highscoreEntryList[i] = highscoreEntryList[j];
                    highscoreEntryList[j] = tmp;
                }
            }
        }

        highscoreEntryTransformList = new List<Transform>();
        foreach (HighscoreEntry highscoreEntry in highscoreEntryList)
        {
            CreateHighscoreEntryTransform(highscoreEntry, entryContainer, highscoreEntryTransformList);
        }
    }
    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform> transformList)
    {
            float templateHeight = 20f;
            Transform entryTransform = Instantiate(entryTemplate, container);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
            entryTransform.gameObject.SetActive(true);
        
            int rank = transformList.Count + 1;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = rank + "TH"; break;

                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
            }
        
            entryTransform.Find("posText").GetComponent<Text>().text = rankString;

            int score = highscoreEntry.score; //this is where the score goes

            entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();            
            
            string name = highscoreEntry.name; // where the name goes

            entryTransform.Find("nameText").GetComponent<Text>().text = name;

            transformList.Add(entryTransform);
    }

    private class HighscoreEntry 
    {
        public int score;
        public string name;
    }
}
