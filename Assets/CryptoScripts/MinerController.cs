using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinerController : MonoBehaviour
{

    // skripta koja provjerava funkciju iz "Game" skripte

	void Update ()
    {
        Game.TryAdvanceMiners();
	}
}
