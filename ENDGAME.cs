using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDGAME : MonoBehaviour
{

    public GameManage gamemange;

    private void OnTriggerEnter()
    {
        gamemange.WonLvel();
        Invoke("qui", 4f);
    }

    private void qui ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
