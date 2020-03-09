using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        GetComponent<AudioSource>().Play();
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
