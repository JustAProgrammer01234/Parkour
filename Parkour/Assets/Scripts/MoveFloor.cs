using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public bool reversed; 

    Animator animator; 
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
    }
}
