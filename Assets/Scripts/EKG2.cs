using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKG2 : MonoBehaviour
{
    public GameObject panel2;
    public int second = 390;
    public int wait2 = 8;

void Update()
{
    if(second <= Time.time)
    {
        panel2.SetActive(true);
    }

    if(second + wait2 <= Time.time)
    {
        panel2.SetActive(false);
    }
}
}
