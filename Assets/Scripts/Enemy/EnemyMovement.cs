using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Vector3 finalPosition;
    public float movingSpeed = 0.5f;

    private Rigidbody2D rb2D;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        if (transform.position.x > finalPosition.x) {
            Vector3 nextPos = transform.position;
            nextPos.x -= movingSpeed * Time.deltaTime;
            rb2D.MovePosition(Vector2.Lerp(nextPos, transform.position, 0));
        }
    }
}
