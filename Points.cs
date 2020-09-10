using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Points : MonoBehaviour
{

    public static int Score = 0;
    public GameObject helplight;
    public SpotLight sp;

    private void OnGUI()
    {
        if (Score < 0)
        {
            FindObjectOfType<GameManage>().EndGame();
            FindObjectOfType<GameManage>().LostLvel();
        }
        else if (Score>=0 )
        {
            GUI.Box(new Rect(180, 100, 100, 100), "Point: " + Score.ToString());
        }

        if (Score>=3)
        {
            helplight.SetActive(true); 
        }

        else
        {
            helplight.SetActive(false);
        }

        

    }
}
