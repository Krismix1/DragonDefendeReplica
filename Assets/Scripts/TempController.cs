using UnityEngine.UI;
using UnityEngine;

public class TempController : MonoBehaviour {

    public GameObject enemyPrefab;

    public void SpawnEnemy() {
        Instantiate(enemyPrefab);
    }
}
