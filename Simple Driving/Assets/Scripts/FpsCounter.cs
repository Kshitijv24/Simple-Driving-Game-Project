using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fpsText;
    float timer, refresh, avgFramerate;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;

        if(timer <= 0)
        {
            avgFramerate = (int)(1f / timelapse);
        }

        fpsText.text = "FPS: " + avgFramerate.ToString();
    }
}
