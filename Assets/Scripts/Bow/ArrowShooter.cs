using UnityEngine;

public class ArrowShooter : MonoBehaviour {

    public GameObject arrowPrefab;

    public int firingRate = 2;
    private float fireCooldown = 0f;

    private int arrowDamage = 10;

    void Update() {
        fireCooldown += Time.deltaTime;
        if (Input.GetMouseButton(0)) {
            if (!Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, float.MaxValue, 5)) {
                Fire();
            }
        }
    }


    void Fire() {
        if (fireCooldown >= 1f / firingRate) {
            fireCooldown = 0;
            GameObject arrowGO = Instantiate(arrowPrefab, transform.position, transform.rotation);
            arrowGO.GetComponent<ArrowDamage>().arrowDamage = arrowDamage;
        }
    }

    public void AddArrowDamage(int amount) {
        arrowDamage += amount;
    }

    public float GetArrowDamage() {
        return arrowDamage;
    }
}
