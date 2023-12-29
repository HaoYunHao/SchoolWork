using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    public GameObject CombineRoot;
    // Start is called before the first frame update
    void Start()
    {
        StaticBatchingUtility.Combine(CombineRoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
