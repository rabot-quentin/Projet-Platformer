using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    void Awake()
    {
        if (Instance != null)
        {
            //Debug.Debug.LogWarning("More than one instance of GameManager found!");
            return;

        }
        Init();
        Instance = this;

    }

    public Player p
    { get; private set; }

    void Init()
    {
        p = new Player();
    }
}
