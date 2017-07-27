using UnityEngine;

public class BowRotation : MonoBehaviour {

    void Update() {
        Turning();
    }

    void Turning() {
        Vector3 mouse_pos;
        Vector3 object_pos;
        float angle;

        mouse_pos = Input.mousePosition;
        mouse_pos.z = -20;
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -90, 90);
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
