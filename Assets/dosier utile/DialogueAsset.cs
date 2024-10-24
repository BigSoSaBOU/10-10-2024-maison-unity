using UnityEngine;

[CreateAssetMenu] //c'est un atribut, ca ajoute une fonctionalité sans modifier son contenue , donc dans unity on peut creée un "New Dialogue asset" se qui cree une nouvelle case ou on va pouvoir stocker les textes (
public class DialogueAsset : ScriptableObject
{
    [TextArea(3,6)] // permet de gerer de grand textes, combien de ligne max aficher et min. donc la 3 ligne minimum ,6 max pour l'asset menu
    public string[] dialogue; //les [] mermet de dire que on fait une liste dans Asset menu, et donc dans asset menu je peut cree diferent dialogues

}
