using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/************************************
TranslateButton déplace le bouton Options du menu principal pour l'afficher sous le panel activé.
************************************/

public class TranslateButton : MonoBehaviour
{
    public int counter;
    private Button button;
    private Vector3 pos;

    // Récupère le bouton Options et sa position actuelle.
    void Start()
    {
        button = GetComponent<Button>();
        pos = button.transform.position;
    }

    // Déplace le bouton vers le bas lorsque le bouton est activé une fois, sinon, le replace à sa position initiale.
    public void TranslateDown() {
        counter++;
        if (counter%2 == 1) {
            button.transform.Translate(0f,-200f,0f);
        } else {
            button.transform.position = pos;
        }
        
    }
}
