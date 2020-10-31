using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string singleString;
    public List<string> collectionList;
    public List<Collectible> collectibleList;

    // Start is called before the first frame update
    private void Start()
    {
        print(singleString);
        print(collectionList[0]);
        print(collectionList[1]);
        print(collectionList[2]);
        print(collectionList[3]);
        print(collectionList[4]);

        for(var i = 0; i <collectibleList.Count; i++)
        {
            var position = new Vector3(i * 2, 0, 0);
            var item = collectibleList[i];
            var newItem = new GameObject(item.name);
            newItem.transform.position = position;
            var sprite = newItem.AddComponent<SpriteRenderer>();
            sprite.sprite = item.art;
            sprite.color = item.artColor;
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
