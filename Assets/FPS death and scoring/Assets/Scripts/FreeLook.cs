using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeLook : MonoBehaviour
{

    // skripta u kojoj se omogučuje igraču da gleda gdje on hoće

    private bool isCursorLocked = true;

    public GameObject Body;

    private float originalFov;

    private Camera thisCam;

    public float ZoomFov = 75;

    void Start()
    {
        thisCam = this.GetComponent<Camera>();
        originalFov = thisCam.fieldOfView;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetAxis("Fire2") > 0)
        {
            thisCam.fieldOfView = Mathf.Lerp(thisCam.fieldOfView, ZoomFov, 0.1f);
        }
        else
        {
            thisCam.fieldOfView = Mathf.Lerp(thisCam.fieldOfView, originalFov, 0.4f);
        }

        var horizontalnaRotacija = Input.GetAxis("Mouse X");
        var vertikalnaRotacija = Input.GetAxis("Mouse Y");

        var trenutnaRotacijaKamere = this.transform.rotation.eulerAngles;
        var trenutnaRotacijaTijela = Body.transform.rotation.eulerAngles;

        var dodatnaRotacijaKamere = new Vector3(vertikalnaRotacija, 0, 0);
        var dodatnaRotacijaTijela = new Vector3(0, horizontalnaRotacija, 0);

        var novaRotacijaKamere = trenutnaRotacijaKamere + dodatnaRotacijaKamere;
        var novaRotacijaTijela = trenutnaRotacijaTijela + dodatnaRotacijaTijela;

        this.transform.rotation = Quaternion.Euler(novaRotacijaKamere);
        Body.transform.rotation = Quaternion.Euler(novaRotacijaTijela);
    }
}
