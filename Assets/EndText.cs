using UnityEngine;
using System.Collections;

public class EndText : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    guiText.text=MyGUIgame.score+("点");
        if (Input.GetKeyDown(KeyCode.A))
        {
            Application.LoadLevel("promapnonkinect");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Application.LoadLevel("promapkinect");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Application.LoadLevel("StartScene");
        }
	}
}
