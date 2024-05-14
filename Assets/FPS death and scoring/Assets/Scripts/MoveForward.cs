using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float Speed = 5f;

    public GameObject Body;

    // skripta za upravljanje pozicije igrača u sceni

    void Update()
    {
        var z = Input.GetAxis("Vertical");
        var x = Input.GetAxis("Horizontal");

        var trenutnaRotacijaY = Body.transform.rotation.eulerAngles.y;

        var rotacijaPomakaNaprijed = Quaternion.Euler(0, trenutnaRotacijaY, 0);

        var pomakNaprijed = rotacijaPomakaNaprijed * Vector3.forward * z * Speed * Time.deltaTime;
        var pomakDesno = Body.transform.right * x * Speed * Time.deltaTime;

        var ukupniPomak = pomakNaprijed + pomakDesno;

        Body.transform.position += ukupniPomak;
    }
}
