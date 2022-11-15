using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public const string HighScoreKey = "HighScore";

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float scoreMultiplier;

    float score = 0;

    private void Start()
    {
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
