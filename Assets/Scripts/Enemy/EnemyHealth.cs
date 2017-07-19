using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private int health = 100;
    [SerializeField]
    private int defense = 15;

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

    public int TakeDamage(int damage) {

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
