using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Example;
    public Transform SpawnPoint;
    public bool Switch;


    void Start()
    {
        
    }

    void Update()
    {
        if (Switch == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube = Instantiate(Example, SpawnPoint.position, SpawnPoint.rotation, transform);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube);
            }
        }

        if (Switch == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cube.GetComponent<MeshRenderer>().enabled = true;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                Cube.GetComponent<MeshRenderer>().enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                Cube.AddComponent<MeshRenderer>();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(Cube.GetComponent<MeshRenderer>());
            }
        }
    

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Switch = !Switch;
        }   
    }
}