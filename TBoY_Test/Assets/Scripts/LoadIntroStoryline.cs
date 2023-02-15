using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/************************************
LoadIntroStoryline gère l'affichage du texte de la "cinématique" d'introduction.
************************************/

public class LoadIntroStoryline : MonoBehaviour
{
    [SerializeField]
    private StorylineSO[] data = new StorylineSO[2];

    TextMeshProUGUI textArea;

    private StorylineSO slSO;
    private int currentText;
    private int nbText;

    // Start is called before the first frame update
    void Start()
    {
        nbText = data.Length;
        textArea = GetComponent<TextMeshProUGUI>();
    }

    public void NextText() {
        if (currentText < (nbText-1)) {
            currentText++;
        } else {
            //currentText = 0;
        }
        slSO = data[currentText];
        textArea.text = slSO.Text;
    }
}
