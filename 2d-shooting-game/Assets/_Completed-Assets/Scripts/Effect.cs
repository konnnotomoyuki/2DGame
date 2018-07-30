using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Effect : MonoBehaviour
{
    Image image;

    private int intWaveLength;   

    // Use this for initialization
    void Start ()
    {
        image = GetComponent<Image>();
        image.color = Color.clear;

        intWaveLength = FindObjectOfType<Emitter>().waves.Length;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (FindObjectOfType<Emitter>().currentWave == intWaveLength)
        {
            this.image.color = new Color(255, 0, 0, 255);
        }
        else
        {
            this.image.color = Color.Lerp(this.image.color, Color.clear, Time.deltaTime);
        }
    }
}
