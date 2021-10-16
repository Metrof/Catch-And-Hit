using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Score;
    public Text ScoreFromLoseMenu;
    public Text record;
    private int myRecord;
    public static int MyScore;

    private void Start()
    {
        myRecord = PlayerPrefs.GetInt("Record");
    }
    void Update()
    {
        if (myRecord < MyScore)
        {
            myRecord = MyScore;
            PlayerPrefs.SetInt("Record", myRecord);
        }
        Score.text = MyScore.ToString();
        ScoreFromLoseMenu.text = MyScore.ToString();
        record.text = myRecord.ToString();
    }
}
