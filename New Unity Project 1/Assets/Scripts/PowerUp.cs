﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        print("OnTriggerEnter");
        if (collision.gameObject) ;
    }

}


