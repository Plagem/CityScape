using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameTime;

    void Start()
    {
        
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        Debug.Log(getTime());
    }

    public float getTime()
    {
        return gameTime;
    }
}
