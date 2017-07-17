using UnityEngine;
using UnityEngine.UI;

public class ManaRegeneration : MonoBehaviour {

    public float manaMaxValue = 100f;
    public Slider manaSlider;
    public Text manaValueText;
    public float manaRegenSpeed = 1f; // The speed of mana regeneration
    public float manaRegenValue = 1f;

    private float currentMana;
    private float manaRegenTimer = 0f;

	// Use this for initialization
	void Start () {
        currentMana = manaMaxValue;
        manaSlider.maxValue = manaMaxValue;
        manaSlider.minValue = 0;
	}

    private void Update() {
        manaRegenTimer += Time.deltaTime;
        if(currentMana < manaMaxValue && manaRegenTimer >= 1 / manaRegenSpeed) {
            manaRegenTimer = 0;
            if (currentMana + manaRegenValue <= manaMaxValue) {
                currentMana += manaRegenValue;
            }
            else {
                currentMana = manaMaxValue;
            }
        }
    }

    void LateUpdate () {
        manaSlider.value = currentMana;
        manaValueText.text = currentMana.ToString();
	}
}
