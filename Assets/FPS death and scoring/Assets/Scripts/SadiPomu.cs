using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadiPomu : MonoBehaviour
{
    public GameObject Poma;

    // skripta kojom uništavamo Pikachu-e u sceni

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var screenMid = new Vector2(Screen.width / 2, Screen.height / 2);

            var ray = this.GetComponent<Camera>().ScreenPointToRay(screenMid);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Destroy")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
