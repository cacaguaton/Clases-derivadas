# Clases-derivadas
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeBase : MonoBehaviour
{
    public  bool isDead = false;
    protected float health = 35f;
    public float getHealth()
    {
        return health;
    }


}

public struct Quest
{
    public int id;
    public string name;
    public string description;
    public string title;
}

public class Heroe:personajeBase
{
    
    private Quest mission;

    public void  setMission(string _name, string _description, string _title)
    {
        mission.id = Random.Range(0, 50);
        mission.name = _name;
        mission.description = _description;
        mission.title = _title;
    }

    public Quest getMission()
    {
        return mission;
    }

    
}

public class EnemigoBase : personajeBase
{
    private float damage = 450;
    public float getDamage()
    {
        return damage;
    }
 
}

public class Caballero : EnemigoBase
{
    private float powerUp = Random.Range(10, 450);
    public float getPowerUp()
    {
        return damage + powerUp;
    }
}

public class HeroeFuerte : Heroe
{
  public float hability = 300f;

    public int getHability()
    {
        if (getMission().id == 2)
        {
            return hability - 20.0f;
        }
        return hability;
    }


}

class Notes : MonoBehaviour
{
    public HeroeFuerte heroeFuerte;
    public Caballero caballero;

    private void Start()
    {
        heroeFuerte = new HeroeFuerte();
        caballero = new Caballero();
        heroeFuerte.setMission("Mission 1", "El uso de atributos en clases", "Clasificacion de atributos", "El gran desafio");
        if (!heroeFuerte.isDead && !caballero.isDead)
        {
            if (heroeFuerte.getHealth() >= 51)
            {
                float combatResult = heroeFuerte.getHability() - caballero.getDamage();
                Debug.Log("El resultado del combate es: " + combatResult);
            }
            else
            {
                Debug.Log("El hero tiene muy poca vida, regresa a la base. Vida " + heroeFuerte.getHealth());
            }
        }
    }

}
