using UnityEngine;
using UnityEngine.UI;

public class CastleHealth : MonoBehaviour {

    public int startingHealth = 1000;
    public Slider healthSlider;
    public Text healthText;

    private int currentHealth;

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

    public int TakeDamage(int amount) {
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
