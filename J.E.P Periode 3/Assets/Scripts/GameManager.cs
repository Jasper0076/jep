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
        StartCoroutine(StartTrack());
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
