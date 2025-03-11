using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public enum SwitchState { None, ScriptOne, ScriptTwo }
    [SerializeField]
    private SwitchState currentSwitchState = SwitchState.None; // D�claration de la variable 'currentSwitchState'.

    //Coche l� avant le d�marage du jeux pour pouvoir choisir le gameplay � tester, tu dois donc choisir dans l'enum avant le d�marage la fonction souhaiter.
    //La variable se trouve en public donc n'�site pas � l'utiliser autres par, c'est comme speed pour l'avoir � distance.
    public static bool DevMode;

    public static float speed = 5.0f; // La variable 'speed' accessible depuis les autres scripts.

    private void Awake()
    {
        if(instance != null )
        {
            Debug.LogError("Plus d'une instance de GameManager est dans la sc�ne!");
            return;
        }
        instance = this;
    }

    void Update()
    {
        // Changer de script quand F12 est press�.
        if (Input.GetKeyDown(KeyCode.F12) || DevMode == true)
        {
            currentSwitchState = (SwitchState)(((int)currentSwitchState + 1) % 3);

            switch (currentSwitchState){
                case SwitchState.ScriptOne:
                    Debug.Log("Script One activ� !");
                    ScriptOne.DisplayMessage();
                    break;
                case SwitchState.ScriptTwo:
                    Debug.Log("Script Two activ� !");
                    ScriptTwo.DisplayMessage();
                    break;
                case SwitchState.None:
                    Debug.Log("Aucun script activ�.");
                    break;
            }
        }
    }
    public void InitGame()
    {
        //�crit ici inisialisation apr�s le changement du script connect�
    }

}
