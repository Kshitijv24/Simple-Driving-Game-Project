using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] int maxEnergy;
    [SerializeField] int energyRechargeDuration;

    const string EnergyKey = "Energy";
    const string EnergyReadyKey = "EnergyReady";

    int energy = 0;


    private void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt(ScoreSystem.HighScoreKey, 0).ToString();

        energy = PlayerPrefs.GetInt(EnergyKey, maxEnergy);

        if(energy == 0)
        {
            
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
