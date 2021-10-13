using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallPaddleManager : MonoBehaviour
{
    public static BallPaddleManager Instance;

    public static string playerName;

    // Sigleton class that destroys other instance if they there are.
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void NameEnter (string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }

    

}
