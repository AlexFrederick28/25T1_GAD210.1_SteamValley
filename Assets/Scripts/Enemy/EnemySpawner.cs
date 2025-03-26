using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject spawnerOne;
    [SerializeField] GameObject spawnerTwo;
    [SerializeField] GameObject spawnerThree;
    [SerializeField] GameObject spawnerFour;

    [SerializeField] GameObject enemyPrefab;

    private float enemyTimeTillSpawn;
    [SerializeField] private float enemyWaitTime;

    private void Update()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        enemyTimeTillSpawn += Time.deltaTime;

        if (enemyTimeTillSpawn >= enemyWaitTime)
        {
            int randomSpawn = 0;
            randomSpawn += Random.Range(0, 10);

            Debug.Log("randomSpawn = " +randomSpawn);

            if (randomSpawn <= 5)
            {
                Vector3 spawn = new Vector3(Random.Range(spawnerOne.transform.position.x, spawnerTwo.transform.position.x), spawnerOne.transform.position.y, 0);

                Instantiate(enemyPrefab, spawn, Quaternion.identity);
            }
            if (randomSpawn >= 6)
            {
                Vector3 spawn = new Vector3(Random.Range(spawnerThree.transform.position.x, spawnerFour.transform.position.x), spawnerThree.transform.position.y, 0);

                Instantiate(enemyPrefab, spawn, Quaternion.identity);
            }

            enemyTimeTillSpawn = 0;
        }

    }

    
}
