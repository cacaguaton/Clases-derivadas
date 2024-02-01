using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        //Name = "Pepe";

        Display();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    // <sumary>
    // Breif : This class is in charge of overriding th emove method from
    //the base class 'Animal'

    public override void move()
    {
        base.move();
    }

}
