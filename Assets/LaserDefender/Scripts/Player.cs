using UnityEngine;

public class Player : MonoBehaviour
{

    // skripta koja igračevom svemirskom brodu daje određena svojstva 
    // start funkcija igraču daje najbližu i najdalju točku kretanja svemirskog broda 
    // update funkcija igraču daje tipku koju koristi za ispaljivanje lasera, tipke za kretanje svemirskog broda i logiku po kojoj se uništava igračev svemirski brod


    public float Speed = 1;
    public GameObject LaserPrebfab;
    public float LaserSpeed = 7;
    public float ShotsPerSecond = 3;
    public float Health = 500;

    float shotTimer = 0;
    float LeftMost, RightMost;
    float padding = 0.5f;

    void Start()
    {
        LeftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x;
        RightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x;
    }

    void Update()
    {
        shotTimer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space) && shotTimer > 1 / ShotsPerSecond)
        {
            var laser = Instantiate(LaserPrebfab, this.transform.position, Quaternion.identity);
            var rb = laser.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.up * LaserSpeed;
            shotTimer = 0;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * Speed * Time.deltaTime;
        }

        if (this.transform.position.x - padding < LeftMost)
        {
            var pos = new Vector3(LeftMost + padding, this.transform.position.y);
            this.transform.position = pos;
        }
        if (this.transform.position.x + padding > RightMost)
        {
            var pos = new Vector3(RightMost - padding, this.transform.position.y);
            this.transform.position = pos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var projectile = collision.gameObject.GetComponent<Projectile>();

        if (projectile)
        {
            Health -= projectile.Damage;

            Destroy(projectile.gameObject);

            if (Health <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
