using UnityEngine;
using System.Collections;

public class matsu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        guiTexture.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (MyGUIgame.score >= 15000 && MyGUIgame.score < 30000)
        {
            guiTexture.enabled = true;
        }
	}
}
