using UnityEngine;

public class ScriptTwo : MonoBehaviour
{
    //Re�us message GameManager
    public static void DisplayMessage()
    {
        //Met tes fonction de changement gameplay ici
        Debug.Log("Message de ScriptTwo : Case 2 activ�e !");
    }

    //Exemple d'acc�s � la variable speed
    private void Start()
    {
        GameManager.speed = 42.0f;
    }
}
