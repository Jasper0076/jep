using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public float score;
    public int lives;
    public GameObject winScreen;
    public GameObject failScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            failScreen.SetActive(true);
        }
        GetComponent<Text>().text = score.ToString("0");
    }
}
