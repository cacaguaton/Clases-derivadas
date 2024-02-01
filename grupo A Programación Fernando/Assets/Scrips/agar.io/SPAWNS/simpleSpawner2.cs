using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleSpawner2 : MonoBehaviour
{
    [Header("Configuration")]
    public List<GameObject> Prefabs;
    public int RoundCount = 5;
    public float TimeBetweenRounds = 3;
    public int SpawnArea = 5;

    [Header("Debug")]
    public float currentTime = 0f;
    public int CurrentRound = 0;

    public void Spawer()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= TimeBetweenRounds)
        {
            ObjectGeneration();
            currentTime = 0f;
            CurrentRound++;
            if (CurrentRound >= RoundCount)
            {
                //Reiniciar el conteo de rondas
                CurrentRound = 0;
                // Ajustamos la frecuencia de generacion
                TimeBetweenRounds *= 0.9f;
            }
        }

    }

    public void ObjectGeneration()
    {
        Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnArea,SpawnArea), Random.Range(-SpawnArea,SpawnArea), 0);
        
        GameObject obj = Prefabs[Random.Range(0, Prefabs.Count)];
        GameObject clone = Instantiate(obj, SpawnPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Spawer();
    }
    private void OnDrawGizmoSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(-SpawnArea, SpawnArea));
    }
}
