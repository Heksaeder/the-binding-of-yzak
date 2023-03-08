using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************
InitializeUI devra gérer l'affichage de l'UI lors des phases sans dialogues.
[Menu] [Sac] [Quit.] 
[Carte]
************************************/

public class InitializeUI : MonoBehaviour
{
    GameObject panel;
    GameObject panelUI;
    // Start is called before the first frame update
    void Awake()
    {
        /* panel = GameObject.Find("Panel");
        panelUI = GameObject.Find("UI");
        Debug.Log("Awake is up");
        panel.SetActive(false);
        panelUI.SetActive(true); */
    }
    
    void Start() {
        // Debug.Log("Start is up");
    }
    
}
