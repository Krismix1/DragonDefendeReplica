using UnityEngine;

public class ArrowDamage : MonoBehaviour {

    public int arrowDamage = 30;
    public float pushBackForce = 10f;
    [Space]
    public float criticalDamageMultiplier = 2f;
    [Range(0, 100)]
    public int criticalChance = 10;
    [Space]
    public GameObject criticalHitIconPrefab;
    public Vector3 criticalHitIconOffset;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Enemy") {
            if (Random.Range(0f, 1f) * 100 < criticalChance) {
                DoCriticalDamage(collision.gameObject, arrowDamage, criticalDamageMultiplier);
            }
            else {
                DoDamage(collision.gameObject, arrowDamage);
            }
            PushBack(collision.gameObject.GetComponent<Rigidbody2D>(), pushBackForce);
            Destroy(gameObject);
        }
    }

    private void PushBack(Rigidbody2D rb, float forceAmount) {
        Debug.Log("Push me back");
        //rb.AddForce(Vector2.right * 50, ForceMode2D.Impulse);
        //rb.velocity *= -1;
    }

    private void DoCriticalDamage(GameObject enemy, int damage, float criticalMultiplier) {
        int criticalDamage = Mathf.RoundToInt(damage * criticalDamageMultiplier);
        GameObject criticalIcon = Instantiate(criticalHitIconPrefab, enemy.transform.position + criticalHitIconOffset, Quaternion.identity);
        Destroy(criticalIcon, .2f);
        DoDamage(enemy, criticalDamage);
    }

    private void DoDamage(GameObject enemy, int damage) {
        enemy.GetComponent<EnemyHealth>().TakeDamage(damage);
    }
}
