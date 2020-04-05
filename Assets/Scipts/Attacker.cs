using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)]
    //Adds the walk speed varable and gives it a value
    [SerializeField] float walkSpeed = 1f;
    
    void Start()
    {
        
    }

    
    void Update()
    {//Equation for movment of sprite
        transform.Translate(Vector2.left * walkSpeed *Time.deltaTime);
        
    }
}
