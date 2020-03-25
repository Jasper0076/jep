using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource song;
    public GameObject startScreen;
    public void Start()
    {
        Time.timeScale = 0;
    }
    public void StartButton()
    {
        if(SceneManager.GetActiveScene().name != "Overworld")
        { 
        Time.timeScale = 1;
        startScreen.SetActive(false);
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
