using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript_refreshements : MonoBehaviour
{
    public GameObject Refreshements;

    // Start is called before the first frame update
    void Start()
    {
        Refreshements.SetActive(false);

    }

    // Update is called once per frame
    public void doClick()
    {
        Debug.Log(message: "literature button clicked");
        Refreshements.SetActive(true);
    }
}
