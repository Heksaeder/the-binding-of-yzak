using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuNew : MonoBehaviour
{
    public Button btnNS;

    // Start is called before the first frame update
    void Start()
    {
        btnNS.onClick.AddListener(NextScene);
    }

    public void NextScene() {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i+1);
    }
}
