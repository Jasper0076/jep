using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public int lives;
    public float distance;
    public float score;
    public float multiplier;
    public float failRange;
    public string keyName;
    public GameObject nearestBeat;
    public GameObject winScreen;
    public GameObject failScreen;
    public ScoreKeeper scoreKeeper;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.Find("Scoretext").GetComponent<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(keyName) && nearestBeat != null)
        {
            CalcDistance();
            AddScore();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beat" && nearestBeat == null)
        {   
            nearestBeat = other.transform.gameObject;
        }
    }
    public void CalcDistance()
    {
        if (nearestBeat != null)
        {
            distance = Vector3.Distance(transform.position, nearestBeat.transform.position);
            Destroy(nearestBeat);
            nearestBeat = null;
        }
    }

    public void AddScore()
    {
        score = 100f - distance;
        multiplier += score / 100f;
        if (score < failRange)
        {
            if (lives == 0)
            {
                failScreen.gameObject.SetActive(true);
            }
            multiplier = multiplier * -1;
        }
        if (multiplier < 1f)
        {
            multiplier = 1f;
        }
        if (multiplier > 10f)
        {
            multiplier = 10f;
        }
        score = score * multiplier;
        scoreKeeper.score += score;
    }
}
