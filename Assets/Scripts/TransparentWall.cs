using UnityEngine;

public class TransparentWall : MonoBehaviour
{

    // skripta koja je korištena kako bi u sceni "Level1" zidovima dala svojstvo transparentnosti ukoliko se igrač odluči približavati zidu

    private Renderer renderer;

    public float MinDistance = 30f;
    public float MaxDistance = 40f;


    void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }


    void Update()
    {
        if (Camera.current)
        {
            var cameraPosition = Camera.current.transform.position;
            var wallPosition = this.transform.position;

            var distance = Vector3.Distance(cameraPosition, wallPosition);

            float alpha;

            if (distance > MaxDistance)
            {
                alpha = 1f;
            }
            else if (distance < MinDistance)
            {
                alpha = 0f;
            }
            else
            {
                alpha = (distance - MinDistance) / (MaxDistance - MinDistance);
            }

            var c = renderer.material.color;

            c.a = alpha;

            renderer.material.SetColor("_Color", c);
        }
    }
}
