using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBlockScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed * -1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
