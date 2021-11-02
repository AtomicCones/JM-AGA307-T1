using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public TargetSizes sizeSelected;
    public TargetManger CarryOnButtonSelected;
    float moveDistance = 500f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
        Setup();
        
    }

    public void Update()
    {
        sizeSelected = (TargetSizes)CarryOnButtonSelected.buttonSizeSelected;

        if (sizeSelected == TargetSizes.Small)
        {
            print("TargetSizes Small selected and modifed");
        }
        if (sizeSelected == TargetSizes.Medium)
        {
            print("TargetSizes Medium selected and modifed");
        }

        if (sizeSelected == TargetSizes.Large)
        {
            print("TargetSizes Large selected and modifed");
        }
    }

    /*public void Update()
    {
        if (floatValueSelected == 0.5f)
        {
            
        }

        if (floatValueSelected == 1f)
        {

        }

        if (floatValueSelected == 2f)
        {

        }
    } */

    public void Setup()
    {
        switch (sizeSelected)
        {
            case TargetSizes.Small:
                float scaleFactor1 = 0.5f;
                transform.localScale = Vector3.one * scaleFactor1;
                break;
            case TargetSizes.Medium:
                float scaleFactor2 = 1f;
                transform.localScale = Vector3.one * scaleFactor2;
                break;
            case TargetSizes.Large:
                float scaleFactor3 = 2f;
                transform.localScale = Vector3.one * scaleFactor3;
                break;
            default:
                Debug.Log("Invalid type selected");
                break;
        } 
    }


    public void OnTriggerEnter()
    {
        meshRenderer.material.color = Color.red;
        Destroy(gameObject, 1f);
    }

    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        transform.Rotate(Vector3.up * 180f);
        yield return new WaitForSecondsRealtime(3f);

        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(-Vector3.forward * Time.deltaTime);
            yield return null;
        }
    }
}


