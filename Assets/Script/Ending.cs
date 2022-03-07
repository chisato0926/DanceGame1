using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    Vector3 Staffrollposition;
    public RectTransform rectTransform;
    public float Endpos;


    // Start is called before the first frame update
    void Start() {
        Staffrollposition = rectTransform.anchoredPosition;

    }

    // Update is called once per frame
    void Update() {

        if (rectTransform.anchoredPosition.y < Endpos) {

            Staffrollposition.y += 1f;
            rectTransform.anchoredPosition = Staffrollposition;
        } else {
            Invoke("changeScene", 2.0f);
        }
    }

    void changeScene() {
        SceneManager.LoadScene("Title");
    }
}
