using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalTracker : MonoBehaviour
{
    private GameObject[] levels;
    public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        levels = new GameObject[4];
        MakeListGameObject(tagName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakeListGameObject(string objectTagName)
    {
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = GameObject.FindGameObjectWithTag(objectTagName);
            Debug.Log("Added");
        }
    }
}
