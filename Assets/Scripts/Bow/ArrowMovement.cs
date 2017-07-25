using UnityEngine;

public class ArrowMovement : MonoBehaviour {

    public float arrowSpeed = 10f;

    Rigidbody2D rb2D;


    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate() {
        rb2D.AddForce(transform.rotation * Vector2.right * arrowSpeed, ForceMode2D.Impulse);
        //rb2D.velocity = transform.rotation * Vector2.right * arrowSpeed;
        //Vector3 pos = transform.position;

        //Vector3 velocity = new Vector3(0, arrowSpeed * Time.deltaTime, 0);

        //pos += transform.rotation * velocity;

        //transform.position = pos;
    }
}
