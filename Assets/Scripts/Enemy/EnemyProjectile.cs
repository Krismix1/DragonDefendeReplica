using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    public int damage = 20;
    public float movingSpeed = 4f;

    private Rigidbody2D rb2D;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        //rb2D.velocity = Vector2.left * movingSpeed;
        rb2D.AddForce(Vector2.left * movingSpeed, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.transform.tag == "Castle") {
            collision.gameObject.GetComponent<CastleHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
