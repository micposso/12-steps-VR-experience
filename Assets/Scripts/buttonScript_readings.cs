using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript_readings : MonoBehaviour
{
    public GameObject Readings;

    // Start is called before the first frame update
    void Start()
    {
        Readings.SetActive(false);

    }

    // Update is called once per frame
    public void doClick()
    {
        Debug.Log(message: "readings button clicked");
        Readings.SetActive(true);
    }
}
