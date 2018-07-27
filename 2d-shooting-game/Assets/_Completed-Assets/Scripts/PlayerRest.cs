using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRest : MonoBehaviour
{
    public GameObject Rest1;

    public GameObject Rest2;

    // Use this for initialization
    void Update ()
    {
        if (FindObjectOfType<Player>().intPlayerNum == 2)
        {
            Rest2.SetActive(false);
        }
        else if (FindObjectOfType<Player>().intPlayerNum == 1)
        {
            Rest1.SetActive(false);
        }
    }	
}
