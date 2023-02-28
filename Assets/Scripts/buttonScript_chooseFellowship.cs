using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonScript_chooseFellowship : MonoBehaviour
{

    public GameObject defaultSelectedButton;

    private void OnEnable()
    {
        EventSystem.current.SetSelectedGameObject(defaultSelectedButton);
    }

    public void SetSelectedButton(GameObject selectedButton)
    {
        EventSystem.current.SetSelectedGameObject(selectedButton);
    }

}

