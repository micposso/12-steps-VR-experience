using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript_literature : MonoBehaviour
{
    public GameObject Literature;

    // Start is called before the first frame update
    void Start()
    {
        Literature.SetActive(false);

    }

    // Update is called once per frame
    public void doClick()
    {
        Debug.Log(message: "literature button clicked");
        Literature.SetActive(true);
    }
}
