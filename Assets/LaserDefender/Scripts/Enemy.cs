using UnityEngine;

public class Enemy : MonoBehaviour
{

    // skripta određuje enemy prefab-u svojstva u igrici
    // update funkcija daje svojstva laseru od enemy-a 
    // privatan void daje naredbu ako dođe do sudara između igračevog svemirskog broda i enemy lasera dolazi do oštećivanje igračevog svemirskog broda te na kraju uništenja ako igračev svemirski brod ima 0 života

    public float Health = 150;
    public GameObject LaserPrebfab;
    public float LaserSpeed = 7;
    public float ShotsPerSecond = 3;
    public float ReloadTime = 1;

    float shotTimer = 0;

    void Update()
    {
        shotTimer += Time.deltaTime;

        if (shotTimer > ReloadTime && Random.value < ShotsPerSecond * Time.deltaTime)
        {
            var laser = Instantiate(LaserPrebfab, this.transform.position, Quaternion.identity);
            var rb = laser.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.down * LaserSpeed;
            shotTimer = 0;
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
