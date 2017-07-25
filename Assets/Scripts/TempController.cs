using UnityEngine.UI;
using UnityEngine;

public class TempController : MonoBehaviour {

    public GameObject enemyPrefab;
    public GameObject sliderPrefab;

    public void SpawnEnemy() {
        GameObject sliderGO = Instantiate(sliderPrefab);
        sliderGO.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
        GameObject enemyGO = Instantiate(enemyPrefab);
        enemyGO.GetComponent<EnemyHealth>().SetHealthSlider(sliderGO.GetComponent<Slider>());
        sliderGO.GetComponent<UIAnchor>().objectToFollow = enemyGO.transform;

        //GameObject tempSliderGO = Instantiate(sliderPrefab);
        //sliderGO.transform.SetParent(FindObjectOfType<Canvas>().transform, false);
        //GameObject tempEnemyGO = Instantiate(temp);
        //tempEnemyGO.GetComponent<EnemyHealth>().SetHealthSlider(tempSliderGO.GetComponent<Slider>());
        //tempSliderGO.GetComponent<UIAnchor>().objectToFollow = tempEnemyGO.transform;
    }
}
