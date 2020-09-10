using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{

    bool GameHasEnd = false;
    public GameObject lostlevelUI;
    public GameObject winnUI;


    public void LostLvel ()
    {
        lostlevelUI.SetActive(true);
    }

    public void WonLvel()
    {
        winnUI.SetActive(true);  
    }


    public void EndGame()
    {
        if (GameHasEnd == false)
        {
            GameHasEnd = true;
            Invoke("Restart", 4f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Points.Score = 0;
        
    }
}
