using UnityEngine;

public class ScriptOne : MonoBehaviour
{
    //Reçus message GameManager
    public static void DisplayMessage()
    {
        //Met tes fonction de changement gameplay ici
        Debug.Log("Message de ScriptOne : Case 1 activée !");
    }

    //Exemple accés à des fonction de GameManager
    private void Start()
    {
        GameManager.instance.InitGame();
    }
}
