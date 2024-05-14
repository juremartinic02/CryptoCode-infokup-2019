using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterSpawner : MonoBehaviour
{

    // skripta za postavljanje i nastajanje Pikachu prefab-a u sceni

    public float SpawnAreaX = 10f;
    public float SpawnAreaY = 10f;
    public float SpawnAreaZ = 10f;

    public GameObject HunterPrefab;

    public GameObject Player;

    public float SpawnsPerSecond = 2f;

    private float timeSinceLastSpawn = 0f;

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(this.transform.position, new Vector3(SpawnAreaX, SpawnAreaY, SpawnAreaZ));
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= 1 / SpawnsPerSecond)
        {
            timeSinceLastSpawn -= 1 / SpawnsPerSecond;

            var spawnX = Random.Range(-SpawnAreaX / 2, SpawnAreaX / 2);
            var spawnY = Random.Range(-SpawnAreaY / 2, SpawnAreaY / 2);
            var spawnZ = Random.Range(-SpawnAreaZ / 2, SpawnAreaZ / 2);

            var spawnPosition = this.transform.position + new Vector3(spawnX, spawnY, spawnZ);

            var hunter = GameObject.Instantiate(HunterPrefab, spawnPosition, Quaternion.identity);

            var hunterScript = hunter.GetComponent<Hunter>();
            hunterScript.Prey = Player.transform;
        }
    }
}