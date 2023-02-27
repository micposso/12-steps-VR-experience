using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript_chooseFellowship : MonoBehaviour
{
    private Button button;
    private Color originalColor;
    private Color hoverColor;

    private void Awake()
    {
        // Get the button component
        button = GetComponent<Button>();

        // Get the original color of the button
        originalColor = button.colors.normalColor;

        // Set the hover color to be a slightly darker version of the original color
        hoverColor = originalColor * 0.9f;
    }

    public void doClick()
    {
        Debug.Log(message: "fellowshipt button clicked");
        ColorBlock colors = button.colors;
        colors.normalColor = hoverColor;
        button.colors = colors;
    }

}

