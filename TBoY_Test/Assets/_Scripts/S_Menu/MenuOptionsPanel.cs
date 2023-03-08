using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/************************************
MenuOptionsPanel gère la désactivation du panel principal lorsque le bouton est actif (compteur impair), et sa réactivation lorsque le compteur est pair.
Cette classe est liée à TranslateButton et ne sert qu'au menu Options pour l'heure.
À ajouter : 
- Gestion du nom du personnage
- Gestion de l'apparence du personnage
************************************/

public class MenuOptionsPanel : MonoBehaviour
{
    
    [SerializeField] public GameObject MainPanel;
    [SerializeField] public GameObject OptionsPanel;
    int counter;

    private void Start() {
        OptionsPanel.gameObject.SetActive(false);
    }
    
    public void DisplayPanel(){
        counter++;
        if (counter%2 == 1) {
            MainPanel.gameObject.SetActive(false);
            OptionsPanel.gameObject.SetActive(true);
        } else {
            MainPanel.gameObject.SetActive(true);
            OptionsPanel.gameObject.SetActive(false);
        }
    } 
}
