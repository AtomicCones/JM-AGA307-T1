using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float moveDistance = 500f;

    public EnemyType myType;
    public float onHitScore;
    public float onDeathScore;
    public float Health;

    void Start()
    {
        StartCoroutine(Move());
        myType = (EnemyType)Random.Range(0, (int)EnemyType.COUNT);
        Setup();
    }

    public void Setup()
    {
        switch (myType)
        {
            case EnemyType.Archer:
                Health = 50f;
                break;
            case EnemyType.OneHand:
                Health = 100f;
                break;
            case EnemyType.TwoHand:
                Health = 200f;
                break;
            default:
                Debug.Log("Invalid type selected");
                break;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Hit();
        }
    }

    public void Hit()
    {
        GameManger.instance.AddScore(10);
    }

    public void Die()
    {

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

    /*

                if (myType == EnemyType.OneHand)
            {
                Health = 100f;
            }
            else if (myType == EnemyType.TwoHand)
            {
                Health = 200f;
            }
            else if (myType == EnemyType.Archer)
            {
                Health = 50f;
            }

     */

}
