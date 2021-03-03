using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_color_change : MonoBehaviour
{
    public Material[] RandomMaterials;
    int RandomMat;
    void Start()
    {
        RandomMat = Random.Range(0, 3);
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = RandomMaterials[RandomMat];
    }
}
