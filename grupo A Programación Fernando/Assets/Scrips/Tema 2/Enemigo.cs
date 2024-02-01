using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo: MonoBehaviour
{
    [SerializeField]
    protected string Name = "Enemy";
    [SerializeField]
    protected int Health = 100;
    [SerializeField]
    protected List<string> Loot;

    /*
    orden de ejecucion

    GameLoop
    Init() o  start;
    Uptate(); actualiza los procedimientos logicos
    
    Tras bamvalinas
    Render(); los presenta en pantalla
    Destroy(); si se necesita destruir



    */

    public virtual void Init()
    {
        Loot = new List<string>();   
    }

    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot()
    {
        return Loot;
    }

    public virtual int GetHealth()
    {
        return Health;
    }

}
