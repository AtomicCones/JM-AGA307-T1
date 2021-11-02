using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MortarHitFrag : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rigidBody;
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

    public void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
