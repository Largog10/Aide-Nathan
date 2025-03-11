using UnityEngine;

public class ScriptTwo : MonoBehaviour
{
    //Reçus message GameManager
    public static void DisplayMessage()
    {
        //Met tes fonction de changement gameplay ici
        Debug.Log("Message de ScriptTwo : Case 2 activée !");
    }

    //Exemple d'accés à la variable speed
    private void Start()
    {
        GameManager.speed = 42.0f;
    }
}
