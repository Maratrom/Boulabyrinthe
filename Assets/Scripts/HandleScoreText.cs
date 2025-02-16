using TMPro;
using UnityEngine;

public class HandleScoreText : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            score++;
        }
        scoreText.text = $"Score: {score}";
    }
}
