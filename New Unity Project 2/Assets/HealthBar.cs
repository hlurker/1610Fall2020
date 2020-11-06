using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    var Health = 100;
    var position = Rect(500, 15, 200, 20);

    function OnTriggerEnter(Object : Collider)
    {
        if (Object.tag == "Obstacle")
        {
            Health -= 50;

        }
    }

    function Update()
    {
        if (Health <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    function OnGUI()
    {
        GUI.backgroundColor = Color.green;
        GUI.HorizontalScrollbar(position, 0, Health, 0, 100);
    }
