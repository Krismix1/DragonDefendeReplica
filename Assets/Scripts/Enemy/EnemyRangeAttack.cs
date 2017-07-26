using UnityEngine;

public class EnemyRangeAttack : MonoBehaviour {

    public float timeBetweenAttacks = 2f;
    public GameObject projectilePrefab;

    private float attackTimer = 0;
    private EnemyMovement movement;

    private Animator anim;

    private void Start() {
        movement = GetComponentInParent<EnemyMovement>();

        anim = transform.parent.gameObject.GetComponentInChildren<Animator>();
    }

    private void Update() {
        attackTimer += Time.deltaTime;
        if(movement.IsAtFinalPosition && attackTimer >= timeBetweenAttacks) {
            Attack();
        }
        else {
            anim.ResetTrigger("Attack");
        }
    }

    void Attack() {
        attackTimer = 0;
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        anim.SetTrigger("Attack");
    }
}
