using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public float maxVelocity;


    public Vector2 xMinMax;
    public Vector2 zMinMax;
    public float moveSpeed;
    public Vector3 targetPos;
    private float targetReachedDistance = 0.1f;

    //slerp  from toRotation 
    // Update is called once per frame
    void Update() {
        if(Vector3.Distance(transform.position, targetPos) < targetReachedDistance)
        {
            targetPos = GetRandomPos();
        }

        // Hier even lerpen, en klaar.
        // Lerpen van cur rot, naar de richting van targetPos.

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(xMinMax.x, xMinMax.y), 0, Random.Range(zMinMax.x, zMinMax.y));
    }
}
