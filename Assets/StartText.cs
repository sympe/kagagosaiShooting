using UnityEngine;
using System.Collections;

public class StartText : MonoBehaviour {
    float timer = 3;
	// Use this for initialization
	void Start () {
        MyGUIgame.score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 2)
        {
            guiText.text = ("") + 3;
        }
        else if(timer>1)
        {
            guiText.text = ("") + 2;
        }
        else if(timer>0)
        {
            guiText.text = ("") + 1;
        }
        else if(timer>-1)
        {
            guiText.text = ("START!!!");
        }
        else
        {
            timer = 3;
            Application.LoadLevel("promapkinectgame");
        }
        timer -= Time.deltaTime;
	}
}
