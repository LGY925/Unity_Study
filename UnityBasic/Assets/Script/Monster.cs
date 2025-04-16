using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public PlayerControl player;
    

    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
    }

  
}
