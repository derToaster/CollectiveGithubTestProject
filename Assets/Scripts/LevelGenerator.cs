using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelGenerator : MonoBehaviour
{




    [SerializeField] private Transform platform, platformParent;

    [SerializeField] private float platformMaxX = 4f, platformMinX = -4f;

    [SerializeField] private int amountOfPlatform = 5;

    [SerializeField] private float platformMaxY = 5f, platformMinY = 1f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amountOfPlatform; i++)
        {
            Vector3 position = new Vector3(Random.Range(platformMinX, platformMaxX),(Random.Range(platformMinY,platformMaxY)),0);
          Transform createStep =  (Transform) Instantiate(platform, position, Quaternion.identity);

          createStep.parent = platformParent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
