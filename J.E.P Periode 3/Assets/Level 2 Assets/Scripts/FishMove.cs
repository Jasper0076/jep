using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
    public Vector2 swimHeight;
    public Vector2 xMinMax;
    public Vector2 zMinMax;
    public float moveSpeed;
    public float rotTime;
    public float targetReachedDistance = 0.1f;
    public Vector3 targetPos;
    public Quaternion rotTo;
    public float afstand;
    private void Start()
    {
        targetPos = GetRandomPos();
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, targetPos) < targetReachedDistance)
        {
            targetPos = GetRandomPos();
        }
       /// else if (Vector3.Distance(transform.position, targetPos)> targetReachedDistance)
        //{
           /// (Vector3.Distance(transform.position, targetPos) / 10);
        //}
        rotTo = Quaternion.FromToRotation(Vector3.forward, targetPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotTo , rotTime * Time.deltaTime);
        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

    }

    Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(xMinMax.x, xMinMax.y), Random.Range(swimHeight.x,swimHeight.y), Random.Range(zMinMax.x, zMinMax.y));
    }
}
