using UnityEngine;

public class LevelStarter : MonoBehaviour {

    public Transform castle;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //castle.size = new Vector2(1f, Camera.main.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f)).y);
        //castle.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x * (-1) - 0.5f, 0f);
        castle.transform.position = new Vector2(Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0f)).x * (-1) + 1.5f, 0f);

    }
}
