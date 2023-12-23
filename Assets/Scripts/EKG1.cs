using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKG1 : MonoBehaviour
{
    public GameObject panel1;
    public int first = 270;
    public int wait1 = 8;

void Update()
{
    if(first <= Time.time)
    {
        panel1.SetActive(true);
    }

    if(first + wait1 <= Time.time)
    {
        panel1.SetActive(false);
    }
}
}

