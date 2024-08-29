using UnityEngine;
using UnityEngine.UI;

public class LevelAndMarksDisplay : MonoBehaviour
{
    public Text marksText;

    void Start()
    {
        marksText = FindObjectOfType<Text>();
        int marks = PlayerPrefs.GetInt("PlayerScore", 0);

        marksText.text = "Marks: " + marks;
    }
}

