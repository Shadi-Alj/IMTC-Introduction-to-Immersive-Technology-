using UnityEngine;
using UnityEngine.UI;

public class ToggleImageObject : MonoBehaviour
{
    public Toggle imageObjectToggle;
    public GameObject imageTrackedObject;

    void Start()
    {
        if (imageObjectToggle == null)
        {
            Debug.LogError("Image Object Toggle is not assigned in the inspector");
            return;
        }

        // Subscribe to the toggle's onValueChanged event
        imageObjectToggle.onValueChanged.AddListener(SetImageObjectVisibility);
    }

    void SetImageObjectVisibility(bool isVisible)
    {
        if (imageTrackedObject != null)
        {
            imageTrackedObject.SetActive(isVisible);
        }
        else
        {
            Debug.LogWarning("Image Tracked Object is not assigned or it's missing");
        }
    }
}