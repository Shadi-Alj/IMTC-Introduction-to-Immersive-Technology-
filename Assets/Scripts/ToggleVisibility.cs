using UnityEngine;
using UnityEngine.UI;

public class ToggleVisibility : MonoBehaviour
{
    public Toggle visibilityToggle;

    void Start()
    {
        if (visibilityToggle != null)
        {
            visibilityToggle.onValueChanged.AddListener(ToggleObjectsVisibility);
        }
    }

    private void ToggleObjectsVisibility(bool isVisible)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Toggleable");
        foreach (GameObject obj in objects)
        {
            if (obj != null && obj != gameObject)
            {
                obj.SetActive(isVisible);
            }
        }
    }
}
