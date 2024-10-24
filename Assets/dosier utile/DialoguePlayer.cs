using TMPro;
using UnityEngine;

public class DialoguePlayer : MonoBehaviour
{
    public DialogueAsset dialogueAsset; //permet de contenir un dialogue donc on lui demane le quelle prendre
    public TMP_Text dialogueText; //permet de dire quelle dialogue aficher
    private int dialogueLineIndex; //permet de stocker le numero des diferents dialogues (genre 1 2 ou 3)
    public GameObject dialogueBox; //dessigne la boite de dialogue 

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0]; //dialogue text prend l'asset dialogue 1 du dialogue asset créé sur le premier script
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))  // si on envoir un input en apuiyant(Down) sur une touche , la c'est la touche entrés , mais en qwerty c'est la touche return
        {
            dialogueLineIndex = dialogueLineIndex + 1; //incrementation peut assui etre reacourcis en "dialogueLineIndex++;" ca ajoute 1 ou le "+= 1"

            if (dialogueLineIndex < dialogueAsset.dialogue.Length) //si ma valeurde dialogue est inferieur a la taille de la liste 
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex]; //alors on afiche le text car le dialogue prend le dialogue de la list corespondant a la valeur .
            }
            else
            {
                dialogueBox.gameObject.SetActive(false); // sinon on masque la boite de dialogue si on a atteind la valeur maximale de liste
            }
        }
    }
}
