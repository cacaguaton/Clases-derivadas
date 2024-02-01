using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string Name = "Animal";
    
    public virtual void move()
    {
        //Logica de movimiento
    }

    public virtual void Display()
    {
        Debug.Log("El Animal se llama:"+ Name);
    }

}
