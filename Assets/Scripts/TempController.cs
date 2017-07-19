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
        int dmgToAdd = int.Parse(dmgInput.text);
        arrowShooter.AddArrowDamage(dmgToAdd);
    }

    public void RemoveDamage() {
        int dmgToRemove = int.Parse(dmgInput.text);
        arrowShooter.AddArrowDamage(-dmgToRemove);
    }
}
