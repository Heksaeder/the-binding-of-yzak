using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/************************************
MenuQuit est déclenché lorsque le boutton Quit est activé.
Ce script permet de quitter l'application.
************************************/

public class MenuQuit : MonoBehaviour
{
    public Button btn;
    
    void Start() {
        btn = GetComponent<Button>();
    }

    public void Quit() {
        Application.Quit();
    }
}
