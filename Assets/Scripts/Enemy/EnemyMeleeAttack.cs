using UnityEngine;

public class EnemyMeleeAttack : MonoBehaviour {

    public float attackRange = .5f;
    public int damage = 10;
    public float timeBetweenAttacks = .5f;
    public LayerMask castleLayer;

    private Animator anim;
    private bool isWalking = true;
    private AnimationClip clip;

    private float attackTimer = 0f; // Maybe set the value to the timeBetweenAttacks in Start, so that
                              // it can attack straight away

    private void Start() {
        anim = GetComponent<Animator>();
        //timeBetweenAttacks = clip.length;
    }


    void Update () {
        Collider2D coll = Physics2D.OverlapCircle(transform.position, attackRange, castleLayer);
        attackTimer += Time.deltaTime;
        if (coll == null) {
            if (!isWalking) {
                isWalking = true;
                anim.SetBool("IsAttacking", false);
            }
            return;
        }
        if (attackTimer >= timeBetweenAttacks /* && enemyHealth.currentHealth > 0*/) {
            Attack(coll);
        }
	}

    void Attack(Collider2D coll) {
        attackTimer = 0;
        anim.SetBool("IsAttacking", true);
        isWalking = false;
        coll.gameObject.GetComponent<CastleHealth>().TakeDamage(damage);
    }
}
