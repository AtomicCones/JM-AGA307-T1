using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    OneHand,
    TwoHand,
    Archer,
    //-----
    COUNT
}

public class EnemyManger : MonoBehaviour
{
    public EnemyType myType;
    public List<Transform> spawnPoints;
    public List<GameObject> enemyTypes;
    public List<GameObject> enemies;

    public float SpawnRate = 2f;

    void Start()
    {
        StartCoroutine(DelayedSpawn(enemyTypes.Count));
    }

    private void Spawn()
    {
        var randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
        Spawn(randomSpawnPoint.position, randomSpawnPoint.rotation);
    }

    private void Spawn(Vector3 worldPosition, Quaternion rotation)
    {
        GameObject newObj = Instantiate(enemyTypes[Random.Range(0, enemyTypes.Count)], worldPosition, rotation);
    }

    IEnumerator DelayedSpawn(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Spawn();
            yield return new WaitForSeconds(2f);
        }
    }

/*    [ContextMenu("Spawn Enemy")]
    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyTypes.Length; i++)
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            GameObject newSpawn = Instantiate(enemyTypes[i], spawnPoints[spawnIndex].position + (Random.onUnitSphere * 2.0f), spawnPoints[spawnIndex].rotation);
            enemies.Add(newSpawn);
            Debug.Log(enemies.Count);
        }
        Debug.Log("Toal." + enemies.Count);
    } */
}
