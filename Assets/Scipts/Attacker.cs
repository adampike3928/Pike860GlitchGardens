using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    //Adds the walk speed varable and gives it a value
    float currentSpeed = 1f;
    //setting the speed
    
    void Start()
    {
        
    }

    
    void Update()
    {//Equation for movment of sprite
        transform.Translate(Vector2.left * currentSpeed *Time.deltaTime);
        
    }
    public void SetMovementSpeed (float speed)
    {
        currentSpeed = speed;

    }


}
