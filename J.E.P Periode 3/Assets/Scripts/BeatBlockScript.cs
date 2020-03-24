using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatBlockScript : MonoBehaviour
{
    public float bpm;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = bpm / -60f * Time.deltaTime;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }

    public IEnumerator TestWait()
    {
        yield return new WaitForSeconds(1);
        print("Ik heb een seconden gewacht!");
    }
}
