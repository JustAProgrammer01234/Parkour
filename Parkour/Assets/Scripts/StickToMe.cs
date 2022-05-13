using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToMe : MonoBehaviour
{
    Transform player;

    void Start()
    {
        player = GameObject.Find("Player").transform; 
    }

    void OnTriggerEnter(Collider other)
    {
        player.transform.parent = transform; 
    }

    void OnTriggerExit(Collider other)
    {
        player.transform.parent = null; 
    }
}
