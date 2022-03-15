using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision);
    }
}
