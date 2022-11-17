using UnityEngine;
using TMPro;

public class FpsCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI fpsText;
    
    float poolingTime = 1f;
    float time;
    int frameCount;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        time += Time.deltaTime;
        frameCount++;

        if(time >= poolingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            fpsText.text = "FPS: " + frameRate.ToString();

            time -= poolingTime;
            frameCount = 0;
        }
    }
}
