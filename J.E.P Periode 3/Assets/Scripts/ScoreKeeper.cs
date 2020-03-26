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
    public AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            Fail();
        }
        GetComponent<Text>().text = score.ToString("0");
    }

    public void Fail()
    {
        failScreen.SetActive(true);
        Time.timeScale = 0;
        song.Stop();
    }

    public void Win()
    {
        winScreen.SetActive(true);
        Time.timeScale = 0;
        song.Stop();
    }
}
