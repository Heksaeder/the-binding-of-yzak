using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    public GameObject fadingImg;


    void Start() {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        Debug.Log("Scene loaded : " + scene.name);
        StartCoroutine(FadingIn());
    }

    IEnumerator FadingIn() {

        fadingImg.GetComponent<Image>().color = Color.black;

        fadingImg.GetComponent<CanvasRenderer>().SetAlpha(1.0f);

        for (float t = 2.5f ; t > 0f; t-= Time.deltaTime) {
            fadingImg.GetComponent<CanvasRenderer>().SetAlpha(t/1.5f);
            yield return null;
        }
    }

    /*public void FadeInScene() {
        StartCoroutine(FadingIn());
    }*/
}
