using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraInteract : MonoBehaviour
{
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;

            if (Physics.Raycast(mouseray, out rayhit, 1000.0f)) {

                if (rayhit.transform.name == "Cube") {
                    SceneManager.LoadScene("Main");
                    // gameObject.active = false;
                }
            }
        }
    }
}
