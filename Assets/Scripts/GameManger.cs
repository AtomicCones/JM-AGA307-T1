using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : Singleton<GameManger>
{
    public float Score;
    public float ScoreMutipler = 1.5f;

    public void AddScore(int amount)
    {
        Score += (int)(float)amount * ScoreMutipler;
    }

    private void Start()
    {
        Debug.Log(Score);
    }

    void Update()
    {
        
    }
}
    
