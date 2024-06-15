using UnityEngine;

public class HelpPanelController : MonoBehaviour
{
    public GameObject helpPanel;

    private void Start()
    {
        // Initially hide the help panel
        if (helpPanel != null)
        {
            helpPanel.SetActive(false);
        }
    }

    public void ShowHelpPanel()
    {
        if (helpPanel != null)
        {
            helpPanel.SetActive(true);
        }
    }

    public void HideHelpPanel()
    {
        if (helpPanel != null)
        {
            helpPanel.SetActive(false);
        }
    }
}

