using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private float health = 100;
    [SerializeField]
    private float defense = 15f;

    private Slider healthSlider;

    private void Start() {
        healthSlider = GetComponentInChildren<Slider>();
        healthSlider.maxValue = health;
        healthSlider.value = health;
        HideSlider();
    }

    private void Update() {
        if (health <= 0) {
            Die();
        }
    }

    private void LateUpdate() {
        healthSlider.value = health;
    }

    public float TakeDamage(float damage) {

        if (health > 0) {
            healthSlider.gameObject.SetActive(true);
            CancelInvoke("HideSlider");
            Invoke("HideSlider", .5f);
            health = health - damage * (1 - defense / 100);
        }
        return health;
    }

    void Die() {
        Destroy(gameObject);
    }

    void HideSlider() {
        healthSlider.gameObject.SetActive(false);
    }
}
