using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMortar : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rigidBody;
    public GameObject mortarPrefab;
    public float fragDecaySpeed = 6;
    public float explosiveForce = 10f;
    public float explosiveRadius = 10f;

    void Start()
    {
        rigidBody.AddForce(transform.forward * speed);
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Target target = other.gameObject.GetComponent<Target>();
            if (target != null)
            {
                target.OnTriggerEnter();
                Destroy(this.gameObject);
            }
        }
    }

    void OnTriggerEnter()
    {
        for (int i = 0; i < 6; i++)
        {
            GameObject mortarPrefab1;
            mortarPrefab1 = Instantiate(mortarPrefab, transform.position, transform.rotation);
            Rigidbody mortarRigidBody = mortarPrefab1.GetComponent<Rigidbody>();
            mortarRigidBody.AddExplosionForce(explosiveForce, mortarPrefab1.transform.position, explosiveRadius, 5f);
            Destroy(mortarPrefab1, fragDecaySpeed);
        }
        Destroy(gameObject);
    }

}

/*
public void OnTriggerEnter()
{
    GameObject projectileIstance;
    projectileIstance = Instantiate(mortarPrefab);
    projectileIstance.GetComponent<Rigidbody>().AddForce(projectileIstance.transform.position * fragSpeed);
    Destroy(projectileIstance, 5);
    Destroy(gameObject);
}
*/

/*
    float getTurnAxis = Input.GetAxis("Horizontal");
    mortarPrefab1.GetComponent<Rigidbody>().AddTorque(transform.up * turnSpeed * getTurnAxis);
*/



/*
     void OnTriggerEnter()
{
    GameObject mortarPrefab1;
    mortarPrefab1 = Instantiate(mortarPrefab, transform.position, transform.rotation);

    Vector3 AngleVelocity;
    AngleVelocity = new Vector3(Random.Range(1, 365), Random.Range(1, 365), Random.Range(1, 365));

    Quaternion deltaRotation = Quaternion.Euler(AngleVelocity * Time.fixedDeltaTime);
    mortarPrefab1.GetComponent<Rigidbody>().MoveRotation(mortarPrefab1.transform.rotation * deltaRotation);

    mortarPrefab1.GetComponent<Rigidbody>().AddForce(mortarPrefab1.transform.position * fragSpeed);
    //mortarPrefab1.GetComponent<Rigidbody>().AddForce(Random.Range(1, 365), Random.Range(1, 5), Random.Range(1, 365), ForceMode.Impulse);

    Destroy(mortarPrefab1, fragDecaySpeed);
    Destroy(gameObject);
}
*/

/*

         for (int i = 0; i < 6; i++)
    {
        GameObject mortarPrefab1;
        mortarPrefab1 = Instantiate(mortarPrefab, transform.position, transform.rotation);
        mortarPrefab1.GetComponent<Rigidbody>().AddTorque(Random.Range(200f, 365f), Random.Range(200f, 365f), Random.Range(200f, 365f));
        mortarPrefab1.GetComponent<Rigidbody>().AddExplosionForce(explosiveForce, mortarPrefab1.transform.position, explosiveRadius, 5f);
        Destroy(mortarPrefab1, fragDecaySpeed);

*/
