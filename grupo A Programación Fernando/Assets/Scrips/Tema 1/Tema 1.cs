using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema1 : MonoBehaviour
{
    public int edad = 21;
    // Start is called before the first frame update
    void Start()
    {
        int resultado = suma(5,5);

        Debug.Log("El resultado es :" + resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void walk()
    {

    }
    int suma(int x, int y)
    {
        return x + y;
    }
}
