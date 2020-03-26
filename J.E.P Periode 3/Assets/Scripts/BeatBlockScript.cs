using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBlockScript : MonoBehaviour
{
    public float speed;
    public ScoreKeeper scoreKeeper;
    public bool finalBlock;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = GameObject.Find("ScoreText").GetComponent<ScoreKeeper>();
        speed = speed * -1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        if(transform.position.z <= -2f)
        {
            scoreKeeper.lives -= 1;
            if(finalBlock == true && scoreKeeper.lives > 0)
            {
                scoreKeeper.Win();
            }
            Destroy(gameObject);
        }
    }
}
