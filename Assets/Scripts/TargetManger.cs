using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetSizes
{
    Small,
    Medium,
    Large,
    //-----
    COUNT
}

public class TargetManger : MonoBehaviour
{
    public TargetSizes TargetType;
    public List<Transform> spawnPoints;
    public GameObject Target;
    public int buttonSizeSelected = 3;
    public int targetSpawnSizeSelected = 3;

    public void Update()
    {
        if (buttonSizeSelected == 0)
        {
            targetSpawnSizeSelected = 0;
            TargetType = TargetSizes.Small;
            print("TARGETMANGER MODFIED TO 0 - SMALL");
        }
        if (buttonSizeSelected == 1)
        {
            targetSpawnSizeSelected = 1;
            TargetType = TargetSizes.Medium;
            print("TARGETMANGER MODFIED TO 1 - MEDIUM");
        }
        if (buttonSizeSelected == 2)
        {
            targetSpawnSizeSelected = 2;
            TargetType = TargetSizes.Large;
            print("TARGETMANGER MODFIED TO 2 - LARGE");
        }
    }

    void Spawn()
    {
        var randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count)];
        Spawn(randomSpawnPoint.position, randomSpawnPoint.rotation);
    }

    private void Spawn(Vector3 worldPosition, Quaternion rotation)
    {
        GameObject newObj = Instantiate(Target, worldPosition, rotation);
    }
}
