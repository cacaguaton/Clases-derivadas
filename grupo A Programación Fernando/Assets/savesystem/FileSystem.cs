using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public static FileSystem Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        {
            Instance = this;
        }
    }
    public void CreateFile(string _name, string _extension)
    {
        //1. Definir el path del archivo
        string path = Application.dataPath + "/" + _name + _extension;
        //2. Revisamos , si el archivo en el path NO existe
        if (!File.Exists(path))
        {
            //3. Creamos el contenido y almacenamos la informacion
            string content = "Login Date: " + System.DateTime.Now + "\n";
            //4 almacenamos la informacion
            File.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Atencion : Estas tratando de crear un archivo con el mismo nombre[ " + _name + _extension + "], verificatu informacion");
        }
    }
    public void CreateFile(string _name, string _extension, Vector3 _vec)
    {
        //1. Definir el path del archivo
        string path = Application.dataPath + "/" + _name + _extension;
        //2. Revisamos , si el archivo en el path NO existe
        if (!File.Exists(path))
        {
            //3. Creamos el contenido y almacenamos la informacion
            string content = _vec.ToString() + "\n";
            Debug.Log("Se almaceno la informacion:" + content);
            //4 almacenamos la informacion
            File.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Atencion : Estas tratando de crear un archivo con el mismo nombre[ " + _name + _extension + "], verificatu informacion");
        }
    }

    private void Start()
    {
        CreateFile("Posicion2", ".save");
    }
}
