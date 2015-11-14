using UnityEngine;
using System.Collections;

public class tosiie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        guiTexture.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (MyGUIgame.score >= 30000 && MyGUIgame.score < 45000)
        {
            guiTexture.enabled = true;
        }
	}
}
