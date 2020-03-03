using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMove : MonoBehaviour
{
  public float maxVelocity;
     
     public float xMax;
     public float zMax;
     public float xMin;
     public float zMin;
         
     private float x;
     private float z;
     private float speed;
     private float angle;
 
     // Use this for initialization
     void Start () {
 
 
         x = Random.Range(-maxVelocity, maxVelocity);
         z = Random.Range(-maxVelocity, maxVelocity);
         angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
         transform.localRotation = Quaternion.Euler( 0, angle, 0);
     }
     //lerp 
     // Update is called once per frame
     void Update () {
 
         speed += Time.deltaTime;
 
         if (transform.localPosition.x > xMax) {
             x = Random.Range(-maxVelocity, 0.0f);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             speed = 0.0f; 
         }
         if (transform.localPosition.x < xMin) {
             x = Random.Range(0.0f, maxVelocity);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
             transform.localRotation = Quaternion.Euler(0, angle, 0); 
             speed = 0.0f; 
         }
         if (transform.localPosition.z > zMax) {
             z = Random.Range(-maxVelocity, 0.0f);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
             transform.localRotation = Quaternion.Euler(0, angle, 0); 
             speed = 0.0f; 
         }
         if (transform.localPosition.z < zMin) {
             z = Random.Range(0.0f, maxVelocity);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             speed = 0.0f; 
         }
 
 
         if (speed > 1.0f) {
             x = Random.Range(-maxVelocity, maxVelocity);
             z = Random.Range(-maxVelocity, maxVelocity);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 180;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             speed = 0.0f;
         }
 
         transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y, transform.localPosition.z + z);
     }
}
