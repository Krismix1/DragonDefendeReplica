using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    public int damage = 20;
    public float movingSpeed = 2f;

    private Rigidbody2D rb2D;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        rb2D.velocity = Vector2.left * movingSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("test");
        if (collision.transform.tag == "Castle") {
            collision.gameObject.GetComponent<CastleHealth>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
