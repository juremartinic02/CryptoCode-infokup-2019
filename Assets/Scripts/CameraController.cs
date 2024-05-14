using UnityEngine;

public class CameraController : MonoBehaviour
{

    // skripta pomoću koje pomičemo kameru u sceni "Level1" kako mi želimo pomoću tipki w, a, s, d 

    public float cameraSpeed = 20f;
    public float cameraBorderThickness = 10f;
    public Vector2 cameraLimit;

    public Camera cam { get; internal set; }

    public float scrollSpeed = 20f;

	void Update ()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - cameraBorderThickness)
        {
            pos.z += cameraSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= cameraBorderThickness)
        {
            pos.z -= cameraSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - cameraBorderThickness)
        {
            pos.x += cameraSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= cameraBorderThickness)
        {
            pos.x -= cameraSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis ("Mouse ScrollWheel");
        pos.y -= scroll * 200f * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, -cameraLimit.x, cameraLimit.x);
        pos.z = Mathf.Clamp(pos.z, -cameraLimit.y, cameraLimit.y);

        transform.position = pos;
	}
}
