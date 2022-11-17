using UnityEngine;
using TMPro;

public class GraphicsQualitySettings : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropDown;

    private void Start()
    {
        dropDown.value = QualitySettings.GetQualityLevel();
    }

    public void ChooseGraphicsQulity(int value)
    {
        QualitySettings.SetQualityLevel(value);
    }
}
