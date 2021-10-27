using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject _gb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnPin();
        }       
    }

    void SpawnPin()
    {
        Instantiate(_gb, transform.position, transform.rotation);
    }
}
