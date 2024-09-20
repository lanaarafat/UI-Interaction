using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject titlePanel;
    public GameObject settingsPanel;

    void Start()
    {
        // Show the title panel at the start
        ShowTitlePanel();
    }

    // Show the Title Panel and hide the Settings Panel
    public void ShowTitlePanel()
    {
        titlePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }

    // Show the Settings Panel and hide the Title Panel
    public void ShowSettingsPanel()
    {
        titlePanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
}
