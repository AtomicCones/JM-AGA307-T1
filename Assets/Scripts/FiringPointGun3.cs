using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringPointGun3 : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 1000;
    public Transform firingPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectileIstance;
            projectileIstance = Instantiate(projectilePrefab, firingPoint.position, firingPoint.rotation);
            projectileIstance.GetComponent<Rigidbody>().AddForce(firingPoint.forward * projectileSpeed);
            Destroy(projectileIstance, 5);
        }
    }
}
