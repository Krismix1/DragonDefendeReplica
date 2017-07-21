using UnityEngine;

public class EnemyRangeAttack : MonoBehaviour {

    public float timeBetweenAttacks = 2f;
    public GameObject projectilePrefab;

    private float attackTimer = 0;
    private EnemyMovement movement;

    private void Start() {
        movement = GetComponent<EnemyMovement>();
    }

    private void Update() {
        attackTimer += Time.deltaTime;
        if(movement.IsAtFinalPosition && attackTimer >= timeBetweenAttacks) {
            Attack();
        }
    }

    void Attack() {
        attackTimer = 0;
        Instantiate(projectilePrefab);
    }
}
