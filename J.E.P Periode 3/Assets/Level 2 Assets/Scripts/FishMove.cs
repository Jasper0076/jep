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
    public float rotTime;
    public Transform rotTo;
    private void Start()
    {
        targetPos = GetRandomPos();
    }
    void Update()
    {
        if(Vector3.Distance(transform.position, targetPos) < targetReachedDistance)
        {
            targetPos = GetRandomPos();
            //rotTo = targetPos;        rip
        }
        transform.rotation = Quaternion.Slerp(transform.rotation,rotTo.rotation , rotTime);



        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        //moved nog vooruit, probeer: transform.Translate(Vector3.targetPos*Time.deltaTime*moveSpeed);
                                                                //---------
    }

    Vector3 GetRandomPos()
    {
        return new Vector3(Random.Range(xMinMax.x, xMinMax.y), 0, Random.Range(zMinMax.x, zMinMax.y));
    }
}
