using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float speed = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up*Time.deltaTime*speed);
    }

    public void ChangeSpeed(float newSpeed){
        this.speed = newSpeed;
    }
}
