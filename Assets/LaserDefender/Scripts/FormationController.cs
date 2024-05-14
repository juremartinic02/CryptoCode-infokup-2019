using UnityEngine;

public class FormationController : MonoBehaviour
{

    // skripta koja definira jedinstvena svojstva Enemy prefab-a u Laser Difender mini igri

    public GameObject EnemyPrefab;
    public float Width = 1;
    public float Height = 1;
    public float Speed = 1;

    float LeftMost, RightMost;
    Vector3 direction = Vector3.left;


    void Start()
    {
        LeftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x;
        RightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x;

        foreach (Transform child in this.transform)
        {
            Instantiate(EnemyPrefab, child);
        }
    }


    void Update()
    {
        this.transform.position += direction * Speed * Time.deltaTime;

        if (this.transform.position.x - Width / 2 < LeftMost)
        {
            direction = Vector3.right;
        }
        if (this.transform.position.x + Width / 2  > RightMost)
        {
            direction = Vector3.left;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(this.transform.position, new Vector3(Width, Height));
    }
}
