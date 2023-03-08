using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


/************************************
FadingScreen crée une fausse animation "fade to black" en gérant l'alpha d'une image noire en fonction du temps.
Ce script lance également la scène "Tutorial", mais sera vouée à être réutilisée pour d'autres transitions.
************************************/

public class FadingScreen : MonoBehaviour
{
    public GameObject fadingImg;

    // Itération en fonction du temps de la valeur alpha d'une image noire.
    IEnumerator FadeToNext(string nextScene) {

        fadingImg.GetComponent<Image>().color = Color.black;

        fadingImg.GetComponent<CanvasRenderer>().SetAlpha(0.0f);

        for (float t = 0.0f ; t < 2.5f ; t+= Time.deltaTime) {
            fadingImg.GetComponent<CanvasRenderer>().SetAlpha(t/1.5f);
            yield return null;
        }

        SceneManager.LoadScene(nextScene);

        /* for (float t = 2.5f ; t > 0f; t-= Time.deltaTime) {
            fadingImg.GetComponent<CanvasRenderer>().SetAlpha(t/1.5f);
            yield return null;
        } */
    }

    public void FadeToNextScene() {
        StartCoroutine(FadeToNext("03_Tutorial"));
    }
}
