using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisisonGravedad : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hubo Colision");
        cubeData = col.gameObject.GetComponent<CubeScript>();
        Debug.Log("Nombre del otro objeto: " + cubeData.objectName);
    }
}
