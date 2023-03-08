using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/************************************
CharByChar gère l'affichage du texte façon "machine à écrire" ainsi que la lecture suivie de chaque objet texte (scriptable objects).
L'animation fade to black est également déclenchée par la procédure EndCheck()
************************************/


public class CharByChar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshProDialogue;
    [SerializeField] TextMeshProUGUI textMeshProName;
    [SerializeField] float time;
    [SerializeField] float timeWords; 

    public FadingScreen fade;
    public GameObject panel;
    public GameObject panelUI;
    public GameObject personnage;

    public Rigidbody2D rb;

    [SerializeField] public StorylineSO[] data;
    private StorylineSO slSO;
    private int currentText;
    private int nbText;

    int i = 0;

    // Lit chaque élément StorylineSO (objets "texte") dans le tableau data.
    // Passe à la scène suivante lorsque l'objet fade existe.
    // Désactive la boîte de dialogue lorsque le texte animé est terminé.
    void EndCheck() {
        if (i <= nbText-1) {
            if (personnage != null) {
                panelUI.SetActive(false);
                rb.constraints = RigidbodyConstraints2D.FreezePosition;
            }
            slSO = data[i];
                textMeshProDialogue.text = slSO.Text;
            if (slSO.CharName != null) {
                textMeshProName.text = slSO.CharName;
            }
            StartCoroutine(TextVisible());
        } else if ((i >= nbText) && (fade != null)) {
            fade.FadeToNextScene();
        } else if (i >= nbText) {
            panel.SetActive(false);
            textMeshProDialogue.text = "";
            textMeshProName.text = "";
            
            if (personnage != null) {
                rb.constraints = RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                panelUI.SetActive(true);
            }
            
        }
    }

    // Récupère le panel à afficher au chargement de la scène, et initialise nbText à la longueur du tableau data.
    void Start() {
        panel = GameObject.Find("Panel");
        personnage = GameObject.Find("Personnage");
        if (personnage != null) {
            panelUI = GameObject.Find("UI");
            rb = GameObject.Find("Personnage").GetComponent<Rigidbody2D>();
        }
        nbText = data.Length;
        EndCheck();
    }

    // Boucle de lecture des caractères à rendre visibles pour un effet "machine à écrire"
    // Implémente un délai entre chaque phrase pour assurer une lecture fluide
    private IEnumerator TextVisible()
    {
        textMeshProDialogue.ForceMeshUpdate();
        int totalVisibleChar = textMeshProDialogue.textInfo.characterCount;
        int counter = 0;

        while(true) {
            int visibleCount = counter % (totalVisibleChar + 1);
            textMeshProDialogue.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleChar) {
                i++;
                Invoke("EndCheck", timeWords);
                break;
            }

            counter += 1;
            yield return new WaitForSeconds(time);

        }
    }
}
