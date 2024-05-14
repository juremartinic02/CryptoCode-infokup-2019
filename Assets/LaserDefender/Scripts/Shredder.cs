using UnityEngine;

public class Shredder : MonoBehaviour
{

    // skripa za enemy projektil u mini igri

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        var box = this.GetComponent<BoxCollider2D>();
        Gizmos.DrawWireCube(this.transform.position, box.size);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
