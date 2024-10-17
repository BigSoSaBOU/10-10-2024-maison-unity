using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;                                  //fonctionalité importé de unity

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;                    //tmp text c'est l'import pour les textes je declare une varible, tu fait le lien,tu la nome
    public TMP_InputField numberInput;
    private object messageInput;

    private int randomNumber;
    
    private void Start()                            //private donc elle n'est pas apelé en dehor du script, void il n'y a pas de retoure
    {
        ResetGame();
    }

    public void Try()
    {
        if (string.IsNullOrWhiteSpace(numberInput.text) == true) //si l'input est egual a rien ou a des espace ,ma valeur est-elle vide
        {
            messageText.text = "entre un bail valide stp frero";
            numberInput.text = "";                  //vide la case input par le joueur
            return; //fin 
        }

        if(int.TryParse(numberInput.text, out int Playernumber))  //tryparse permet de transformer une chaine de characters rt nombre ; si la chaine de chrarchter et un nombre 
        {
            if (Playernumber == randomNumber)
            {
                messageText.text = "ti est un monstre";
            }

            else if (Playernumber > randomNumber)
            {
                messageText.text = "trop grand frerot";
            }

            else if (Playernumber < randomNumber)
            {
                messageText.text = "trop petit ma reufeu";
            }

          

        }
        else
        {
            messageText.text = "entre un bail valide stp frero";
            
        }
        numberInput.text = "";
    }
    public void ResetGame()
    {
        //messageText.text = "hello world";//.text = la vairable qui s'apelle message text,prend la valeur text a l'aquelle on donne hello
        randomNumber = Random.Range(1, 101);        //privat int qui s'appele randomNumber prend un nombre au hazard de 1 a 100, la plus petit valeur et inclu, la plus haut non, donc pour avoir 100 on met 101
                                                    // Debug.Log("nombre : " + randomNumber);      //Dubug.log sert a aficher dans la console
        messageText.text = "devine reufeu";
    }
}
