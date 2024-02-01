using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : BallBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public override void move()
    {

        //Accedemos a  la posision del mouse
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePosition.z = 0f;
        //Calculamos la direccion
        Vector3 direction = (MousePosition - transform.position).normalized;

        //Mover al objeto a la direcion calculada
        transform.Translate(direction * Speed * Time.deltaTime);
    }
}
