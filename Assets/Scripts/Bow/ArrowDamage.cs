using UnityEngine;

public class ArrowDamage : MonoBehaviour {

    public float arrowDamage = 10f;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Enemy") {
            float healthLeft = collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(arrowDamage);
            Destroy(gameObject);
            Debug.Log(healthLeft);
        }
    }
}
