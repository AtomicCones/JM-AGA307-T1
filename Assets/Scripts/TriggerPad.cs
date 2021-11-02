using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    public GameObject Sphere;   //The object we wish to change
    public MeshRenderer meshRenderer;
    public float growSpeed = 0.05f;
    public float orginalScale;

    private void Start()
    {
        orginalScale = Sphere.transform.localScale.x;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            //change the spheres colour to green
            meshRenderer.material.color = Color.green;
            Debug.Log("OnEnter Press");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Increas the spheres scale by 0.01 on all axis
            Sphere.transform.localScale += Vector3.one * growSpeed * Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //set the spheres size back to 1
            meshRenderer.material.color = Color.yellow;
            Sphere.transform.localScale = Vector3.one * orginalScale;

        }
    }
}

