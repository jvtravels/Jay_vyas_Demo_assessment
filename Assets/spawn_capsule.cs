using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_capsule : MonoBehaviour
{
    public Vector3 RandomPos;
    void Start()
    {
        RandomPos = new Vector3(Random.Range(-4.5f, 4.5f), 1f, Random.Range(-4.5f, 4.5f));
        transform.position = RandomPos;
    }

    void Update()
    {

    }
}
