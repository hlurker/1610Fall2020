using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public string singleString;
    public List<string> collectionList;

    // Start is called before the first frame update
    void Start()
    {
        print(singleString);
        print(collectionList[0]);
        print(collectionList[1]);
        print(collectionList[2]);
        print(collectionList[3]);
        print(collectionList[4]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
