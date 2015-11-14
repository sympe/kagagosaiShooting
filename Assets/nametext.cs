using UnityEngine;
using System.Collections;

public class nametext : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (MyGUIgame.score < 15000)
        {
            guiText.text = ("農民レベル");
        }
        else if (MyGUIgame.score < 30000)
        {
            guiText.text = ("まつレベル");
        }
        else if (MyGUIgame.score < 45000)
        {
            guiText.text = ("前田利家級");
        }
        else if (MyGUIgame.score < 1000000)
        {
            guiText.text = ("前田慶次郎級");
        }
	}
}
