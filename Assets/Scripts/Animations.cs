using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animations : MonoBehaviour
{
    private Animator anim;
    private Vector3 OldPosition;

    void Start()
    {
        Vector3 OldPosition = transform.position;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(OldPosition != transform.position)
        {
            anim.SetBool("IsMoving", true);
            OldPosition = transform.position;
        }
        else 
        {
            anim.SetBool("IsMoving", false);
        }
    }
}