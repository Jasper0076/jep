using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour
{
    public float multiplier;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (multiplier < 1f)
        {
            multiplier = 1f;
        }
        if (multiplier > 10f)
        {
            multiplier = 10f;
        }
        GetComponent<Text>().text = "X " + multiplier.ToString("0");
    }
}
