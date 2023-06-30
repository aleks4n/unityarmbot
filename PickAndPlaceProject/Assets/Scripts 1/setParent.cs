using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setParent : MonoBehaviour
{
    public Transform parentToSet;
    // Start is called before the first frame update
    void Start()
    {
        SetParent();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetParent()
    {
        transform.SetParent(parentToSet);
    }
}
