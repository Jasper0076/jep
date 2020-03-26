using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBlockScript : MonoBehaviour
{
    public float speed;
    public ScoreKeeper scoreKeeper;
    public bool finalBlock;
    public Multiplier multiplierS;
    public int buffer;
    // Start is called before the first frame update
    void Start()
    {
        multiplierS = GameObject.Find("MultiplierText").GetComponent<Multiplier>();
        buffer = -2;
        scoreKeeper = GameObject.Find("ScoreText").GetComponent<ScoreKeeper>();
        speed = speed * -1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if(transform.position.z <= buffer)
        {
            scoreKeeper.lives -= 1;
            if(finalBlock == true && scoreKeeper.lives > 0)
            {
                scoreKeeper.Win();
            }
            multiplierS.multiplier = 1;
            Destroy(gameObject);
        }
    }
}
