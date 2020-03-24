using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource song;
    public float startTrackTime;
    public void Start()
    {
        Time.timeScale = 0;
    }

    IEnumerator StartTrack()
    {
        yield return new WaitForSeconds(startTrackTime);
        if(SceneManager.GetActiveScene().name != "Overworld")
        { 
        song = GetComponent<AudioSource>();
        song.volume = 0.5f;
        song.Play();
        }
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        StartCoroutine(StartTrack());
    }
    public void ToOverworld()
    {
        SceneManager.LoadScene("Overworld");
    }

    public void ToLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ToLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void ToLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
