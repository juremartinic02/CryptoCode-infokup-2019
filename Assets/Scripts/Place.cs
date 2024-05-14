using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Place : MonoBehaviour
{

    // prtiskom na dugme "Prize" u "Shop 1, 2 ili 3" sceni stvorimo prefab miner-a koji možemo postaviti na jedno od deset mjesta za miner-e

    public GameObject Mine1Prefab;
    public GameObject Mine2Prefab;
    public GameObject Mine3Prefab;
    public GameObject Mine4Prefab;
    public GameObject Mine5Prefab;

    public Camera ViewCamera;

    private int tileNumber;

    private GameObject currentPlaceableObject;

    private float mouseWheelRotation;

    private void Start()
    {
        HandleNewObjectSpawn();
    }

    private void Update()
    {
        if (currentPlaceableObject != null)
        {
            MoveCurrentPlaceableObjectToMouse();
            RealiseIfClicked();
        }
    }

    private void RealiseIfClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentPlaceableObject = null;

            Game.PlaceMineOnTile(tileNumber);

            Game.Save();
        }
    }

    private void MoveCurrentPlaceableObjectToMouse()
    {
        Ray ray = ViewCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        var tilesLayerMask = LayerMask.GetMask("MineTiles");

        if (Physics.Raycast(ray, out hitInfo, 1000f, tilesLayerMask))
        {
            if (hitInfo.collider.gameObject.tag == "Placeable")
            {
                var placeableTile = hitInfo.collider.gameObject.GetComponent<PlaceTag>();

                tileNumber = placeableTile.Number;

                if (CanPlaceOnTile(tileNumber))
                {
                    currentPlaceableObject.transform.parent = hitInfo.collider.gameObject.transform;

                    currentPlaceableObject.transform.position = hitInfo.collider.gameObject.transform.position;
                    currentPlaceableObject.transform.rotation = hitInfo.collider.gameObject.transform.rotation;
                }
            }

        }
    }

    private bool CanPlaceOnTile(int tileNumber)
    {
        if (tileNumber == 1)
        {
            return !Game.Tile1;
        }

        if (tileNumber == 2)
        {
            return !Game.Tile2;
        }

        if (tileNumber == 3)
        {
            return !Game.Tile3;
        }

        if (tileNumber == 4)
        {
            return !Game.Tile4;
        }

        if (tileNumber == 5)
        {
            return !Game.Tile5;
        }

        if (tileNumber == 6)
        {
            return !Game.Tile6;
        }

        if (tileNumber == 7)
        {
           return !Game.Tile7;
        }

        if (tileNumber == 8)
        {
            return !Game.Tile8;
        }

        if (tileNumber == 9)
        {
            return !Game.Tile9;
        }

        if (tileNumber == 10)
        {
            return !Game.Tile10;
        }

        return false;
    }

    private void HandleNewObjectSpawn()
    {
        if (Game.ShouldSpawnMiner)
        {
            var minerPrefabToSpawn = GetMinerPrefabForCurrentMinerLevel();

            currentPlaceableObject = Instantiate(minerPrefabToSpawn);

            tileNumber = 0;
            Game.ShouldSpawnMiner = false;
        }
    }

    private GameObject GetMinerPrefabForCurrentMinerLevel()
    {
        switch (Game.SpawnMinerLevel)
        {
            case 1:
                return Mine1Prefab;
                break;
            case 2:
                return Mine2Prefab;
                break;
            case 3:
                return Mine3Prefab;
                break;
            case 4:
                return Mine4Prefab;
                break;
            case 5:
                return Mine5Prefab;
                break;
            default:
                return Mine1Prefab;
                break;
        }
    }
}
