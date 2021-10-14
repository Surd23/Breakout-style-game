using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallPaddleManager : MonoBehaviour
{
    public static BallPaddleManager Instance;

    public static string playerName;

    private void Start()
    {
        playerName = "No name";
    }

    // Sigleton class that destroys other instance if they there are.
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);            
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    

}
