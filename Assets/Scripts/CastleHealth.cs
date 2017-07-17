using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour {

    public float startingHealth = 1000f;
    public Slider healthSlider;
    public Text healthText;

    private float currentHealth;

    private void Start() {
        currentHealth = startingHealth;
        healthSlider.minValue = 0f;
        healthSlider.maxValue = startingHealth;
    }

    private void Update() {
        if(currentHealth <= 0) {
            Die();
            return;
        }
    }

    private void LateUpdate() {
        healthText.text = currentHealth.ToString();
        healthSlider.value = currentHealth;
    }

    public float TakeDamage(float amount) {
        if (currentHealth > 0) {
            currentHealth -= amount;
        }
        return currentHealth;
    }

    void Die() {
        Destroy(gameObject);
        Debug.Log("You lost!");
    }
}
