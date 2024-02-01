using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public string Name = "Ball";
    public float Speed = 5f;
    public float  AreaDetection = 2f;
    public Vector3 MousePosition;

    
    public virtual void move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Accedemos a  la posision del mouse
            MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MousePosition.z = 0f;
        }

        //Calculamos la direccion
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direcion calculada
        transform.Translate(direction * Speed * Time.deltaTime);

    }

}
