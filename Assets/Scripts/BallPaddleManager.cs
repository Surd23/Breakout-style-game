using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPaddleManager : MonoBehaviour
{
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameEnter (string name)
    {
        playerName = name;
        Debug.Log(playerName);
    }
}
