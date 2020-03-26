using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float distance;
    public float score;
    public float multiplier;
    public float failRange;
    public string keyName;
    public bool finalBeat;
    public GameObject nearestBeat;
    public ScoreKeeper scoreKeeper;
    public Multiplier multiplierS; 
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.Find("ScoreText").GetComponent<ScoreKeeper>();
        multiplierS = GameObject.Find("MultiplierText").GetComponent<Multiplier>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(keyName) && nearestBeat != null && Time.timeScale == 1)
        {
            CalcDistance();
            AddScore();
        }
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
        {

            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.gameObject.tag == "Beat" && nearestBeat == null)
            {
                nearestBeat = hit.transform.gameObject;
            }

            if (hit.transform.gameObject.GetComponent<BeatBlockScript>().finalBlock == true)
            {
                finalBeat = true;
            }
        }

    }

    public void CalcDistance()
    {
        if (nearestBeat != null)
        {
            distance = Vector3.Distance(transform.position, nearestBeat.transform.position);
        }
    }

    public void AddScore()
    {
        score = 100f - distance;
        multiplierS.multiplier += score / 100f;

        if (distance > failRange)
        {
            scoreKeeper.lives -= 1;
            multiplierS.multiplier = 1;
        }
        
        score = score * multiplierS.multiplier;
        scoreKeeper.score += score;
        if(finalBeat == true)
        {
            scoreKeeper.Win();
        }
        Destroy(nearestBeat);
        nearestBeat = null;
    }
}
