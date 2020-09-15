using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 5f;
    public int score = 100;
    public float speed = 3f;

    // start is called before the first frame update
    private void Update()
    {
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);
    }

    // Update is called once per frame
    public void Up()
    {
        print("Up.");
    }

}