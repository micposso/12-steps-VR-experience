using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript_hangBanners : MonoBehaviour
{
    // banner game objects
    public GameObject BannersGroup;

    // Start is called before the first frame update
    void Start()
    {
        BannersGroup.SetActive(false);
    }


    public void doClick()
    {
        Debug.Log(message: "hang banners button clicked");
        BannersGroup.SetActive(true);

    }
}
