using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{

    // skripta koja naređuje Pikachu prefab-ima da prate igrača i ako igrač uništi Pikachu prefab rezultat se povećava za 1

    public Transform Prey;

    public float Speed = 2f;

    void Update()
    {
        this.transform.LookAt(Prey);

        this.transform.position += this.transform.forward * Speed * Time.deltaTime;
    }

    void OnDestroy()
    {
        Hunter_Static.Score++;
    }
}
