using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject nearestBeat;
    public float distance;
    public string keyName;
    public float threshold;
    public float score;
    public float multiplier;
    public float failRange;
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
            nearestBeat = null;
        }
    }

    public void AddScore()
    {
        score = 100f - distance;
        multiplier += score / 100f;
        if (score < failRange)
        {
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
