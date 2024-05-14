using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMove : MonoBehaviour
{

    // skripta za kretnju igrača 

    public float TranslationSpeed = 5f;

    void Update()
    {
        var z = Input.GetAxis("Horizontal");
        var x = Input.GetAxis("Vertical");

        var pomak = new Vector3(x, 0, z) * TranslationSpeed * Time.deltaTime;

        this.transform.position += pomak;
    }
}
