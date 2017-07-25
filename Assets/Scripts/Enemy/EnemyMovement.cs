using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Vector3 finalPosition;
    public float movingSpeed = 0.5f;

    private Rigidbody2D rb2D;
    private Animator anim;
    private bool isWalking;

    private void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    void FixedUpdate() {
        if (transform.position.x > finalPosition.x) {
            //Vector3 nextPos = transform.position;
            //nextPos.x -= movingSpeed * Time.deltaTime;
            //rb2D.MovePosition(Vector2.Lerp(nextPos, transform.position, 0));

            //rb2D.AddForce(Vector2.left * 10 * Time.deltaTime, ForceMode2D.Impulse);

            //rb2D.velocity = Vector2.left * 100 * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, finalPosition, movingSpeed * Time.deltaTime);
            if (!isWalking) {
                isWalking = true;
                anim.SetBool("IsIdle", false);
            }
        }
        else {
            rb2D.velocity = Vector2.zero;
            if (isWalking) {
                isWalking = false;
                anim.SetBool("IsIdle", true);
            }
        }
    }

    public bool IsAtFinalPosition {
        get { 
            return transform.position.x <= finalPosition.x;
        }
    }
}
