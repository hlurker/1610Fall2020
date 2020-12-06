using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public IntData cashTotal;
    public Collectible collectibleObj;
    public Text txtObj;
    private SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = collectibleObj.art;
        renderer.color =
        txtObj.text = cashTotal.value.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        cashTotal.value += 100;
        txtObj.text = cashTotal.value.ToString();
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
