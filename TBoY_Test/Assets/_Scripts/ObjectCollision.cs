using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

/**********************************
ObjectCollision permet de récupérer un objet Collision2D et d'afficher un panel selon le tag de l'objet rencontré.
Chaque texte est géré par un Scriptable Object spécifique.
**********************************/
public class ObjectCollision : MonoBehaviour
{   
    GameObject panel;
    public TextMeshProUGUI tmpText;
    public TextMeshProUGUI tmpName;
    private GameObject go;
    int i;
    int sceneIndex;    
    private TextData txtData;
    

    // Récupère les éléments de la boîte de dialogue (Panel + 2 TMP)
    void Start()
    {
        panel = GameObject.Find("Panel");
        tmpText = GameObject.Find("Dialogue").GetComponent<TextMeshProUGUI>();
        tmpName = GameObject.Find("Nom").GetComponent<TextMeshProUGUI>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Récupère l'objet collision et teste le tag pour afficher ou non la boîte de dialogue correspondante.
    private void OnCollisionEnter2D(Collision2D cls) {
        txtData = cls.gameObject.GetComponent<TextData>();
        if (cls.collider.tag == "Furniture") {
            panel.SetActive(true);
            for (i = 0 ; i < txtData.data.Length;i++) {
                txtData.slSO = txtData.data[i];
                tmpText.text = txtData.slSO.Text;
                tmpName.text = txtData.slSO.CharName;
            }
        } else if (cls.collider.tag == "DoorToRight") {
            SceneManager.LoadScene(sceneIndex+1);
        } else if (cls.collider.tag == "DoorToLeft") {
            SceneManager.LoadScene(sceneIndex-1);
        } else{
            panel.SetActive(false);
        }
    }

    // Récupère la sortie de collision pour désactiver la boîte de dialogue
    private void OnCollisionExit2D(Collision2D cls) {
        if (cls.collider.tag == "Furniture") {
            panel.SetActive(false);
        }
    }
    
}
