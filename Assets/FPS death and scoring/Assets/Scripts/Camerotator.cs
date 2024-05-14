using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerotator : MonoBehaviour
{

    // skripta za kameru koja se nalazi u Pikachu mini igri

    public float BrzinaRotacije = 120f;
    public float BrzinaTranslacije = 10f;

    public Transform RotateAround;

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        var kutRotacije = horizontal * BrzinaRotacije * Time.deltaTime;

        this.transform.RotateAround(RotateAround.position, Vector3.up, kutRotacije);
    }
}
