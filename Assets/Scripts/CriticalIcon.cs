using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalIcon : MonoBehaviour {

    public Vector3 offset;
    public float timeTillHide = .2f;

    private GameObject iconGO;

    private void Start() {
        iconGO = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update() {
        transform.position = transform.parent.position + offset;
    }

    public void ShowIcon() {
        iconGO.SetActive(true);
    }

    public void HideIcon() {
        iconGO.SetActive(false);
    }

    public void ShowAndHideIcon() {
        ShowIcon();
        Invoke("HideIcon", timeTillHide);
    }
}
