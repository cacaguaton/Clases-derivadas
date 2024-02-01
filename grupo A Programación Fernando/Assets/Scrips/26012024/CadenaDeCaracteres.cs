using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenaDeCaracteres : MonoBehaviour
{
    public string data = "x:2, y:5, z:8";
    public Vector3 position;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        //1. Recorrer nuestro string = "x:2, y:5, z:8"
        for (int i = 0; i < data.Length; i++)
        {
            //2. Revisar si el valor en el incide (data[i], es igual a 'x')
            if (data[i] == 'x')
            {
                //3. si, si es el valor, transformaremos el caracter(data[i+2]) a entero
                int x = (int)char.GetNumericValue(data[i + 2]);
                //4. almacenamos la informacion de x en nuestro vector posision
                position = new Vector3(x, position.y, position.z);
            }

            //2. Revisar si el valor en el incide (data[i], es igual a 'x')
            if (data[i] == 'y')
            {
                //3. si, si es el valor, transformaremos el caracter(data[i+2]) a entero
                int y = (int)char.GetNumericValue(data[i + 2]);
                //4. almacenamos la informacion de x en nuestro vector posision
                position = new Vector3(position.x, y, position.z);
            }

            //2. Revisar si el valor en el incide (data[i], es igual a 'x')
            if (data[i] == 'z')
            {
                //3. si, si es el valor, transformaremos el caracter(data[i+2]) a entero
                int z = (int)char.GetNumericValue(data[i + 2]);
                //4. almacenamos la informacion de x en nuestro vector posision
                position = new Vector3(position.x, position.y, z);
            }
        }
        FileSystem.Instance.CreateFile("Posiciones", "save", position);
        Instantiate(prefab,position, Quaternion.identity);

    }
}
