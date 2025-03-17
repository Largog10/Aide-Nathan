using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public enum SwitchState { None, ScriptOne, ScriptTwo }
    [SerializeField]
    private SwitchState currentSwitchState = SwitchState.None; // Déclaration de la variable 'currentSwitchState'.

    //Choisi true ou false là avant le démarage du jeux pour pouvoir choisir le gameplay à tester, tu dois donc choisir dans l'enum avant le démarage la fonction souhaiter.
    //Ne change pas le mod en realtime
    //La variable se trouve en public donc n'ésite pas à l'utiliser autres par, c'est comme speed pour l'avoir à distance.
    [SerializeField]
    public static bool DevMode = true;

    public static float speed = 5.0f; // La variable 'speed' accessible depuis les autres scripts.

    private void Awake()
    {
        if(instance != null )
        {
            Debug.LogError("Plus d'une instance de GameManager est dans la scène!");
            return;
        }
        instance = this;
    }

    void Update()
    {
        // Changer de script quand F12 est pressé.
        if (Input.GetKeyDown(KeyCode.F12))
        {
            currentSwitchState = (SwitchState)(((int)currentSwitchState + 1) % 3);

            switch (currentSwitchState)
            {
                case SwitchState.ScriptOne:
                    Debug.Log("Script One activé !");
                    ScriptOne.DisplayMessage();
                    break;
                case SwitchState.ScriptTwo:
                    Debug.Log("Script Two activé !");
                    ScriptTwo.DisplayMessage();
                    break;
                case SwitchState.None:
                    Debug.Log("Aucun script activé.");
                    break;
            }
        }
        //Gestion du devmode
        //Pas trés bien implémenter, mais tu devras le ritirer quand tu auras un bon code
        else if (DevMode == true)
        {
            currentSwitchState = (SwitchState)(int)currentSwitchState;

            switch (currentSwitchState)
            {
                case SwitchState.ScriptOne:
                    Debug.Log("Script One activé !");
                    ScriptOne.DisplayMessage();
                    break;
                case SwitchState.ScriptTwo:
                    Debug.Log("Script Two activé !");
                    ScriptTwo.DisplayMessage();
                    break;
                case SwitchState.None:
                    Debug.Log("Aucun script activé.");
                    break;
            }
            //Pasage du DevMode à false pour ne pas faire des boucles
            DevMode = false;
        }
    }

    public void InitGame()
    {
        //écrit ici inisialisation aprés le changement du script connecté
    }

}
