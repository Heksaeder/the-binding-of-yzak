using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadingInScreen : MonoBehaviour
{
    public GameObject fadingImg;

    public IEnumerator FadingIn() {
        for (float t = 2.5f ; t > 0f; t-= Time.deltaTime) {
            fadingImg.GetComponent<CanvasRenderer>().SetAlpha(t/1.5f);
            yield return null;
        }
    }
}
