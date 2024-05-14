using UnityEngine;

public class EnemySpawnerGizmo : MonoBehaviour
{

    // stvara enemy prefab-e u sceni

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(this.transform.position, 0.4f);
    }
}
