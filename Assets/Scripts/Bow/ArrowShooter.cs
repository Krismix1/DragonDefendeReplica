using UnityEngine;

public class ArrowShooter : MonoBehaviour {

    public GameObject arrowPrefab;

    public int firingRate = 2;
    private float fireCooldown = 0f;

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
            Instantiate(arrowPrefab, transform.position, transform.rotation);
        }
    }
}
