using UnityEngine.UI;
using UnityEngine;

public class TempController : MonoBehaviour {

    public GameObject enemyPrefab;
    public InputField dmgInput;

    private ArrowShooter arrowShooter;

    private void Start() {
        arrowShooter = GameObject.FindGameObjectWithTag("ArrowShooter").GetComponent<ArrowShooter>();
    }

    public void SpawnEnemy() {
        Instantiate(enemyPrefab);
    }

    public void AddDamage() {
        float dmgToAdd = float.Parse(dmgInput.text);
        arrowShooter.AddArrowDamage(dmgToAdd);
    }

    public void RemoveDamage() {
        float dmgToRemove = float.Parse(dmgInput.text);
        arrowShooter.AddArrowDamage(-dmgToRemove);
    }
}
