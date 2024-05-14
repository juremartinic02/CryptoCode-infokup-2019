using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellMine : MonoBehaviour
{

    // skripta koja sadrži funkciju prodavanja miner-a

    private void OnMouseUpAsButton()
    {
        if (Game.ShouldSellMiner)
        {
            var parent = this.gameObject.transform.parent;

            var tile = parent.GetComponent<PlaceTag>();

            if (tile)
            {
                Game.RemoveMineFromTile(tile.Number);
                Game.ShouldSellMiner = false;

                Destroy(this.gameObject);
            }
        }
    }
}
