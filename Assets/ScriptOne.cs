using UnityEngine;

public class ScriptOne : MonoBehaviour
{
    //Re�us message GameManager
    public static void DisplayMessage()
    {
        //Met tes fonction de changement gameplay ici
        Debug.Log("Message de ScriptOne : Case 1 activ�e !");
    }

    //Exemple acc�s � des fonction de GameManager
    private void Start()
    {
        GameManager.instance.InitGame();
    }
}
