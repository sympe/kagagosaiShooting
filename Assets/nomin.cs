using UnityEngine;
using System.Collections;

public class nomin : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        guiTexture.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (MyGUIgame.score < 15000)
        {
            guiTexture.enabled = true;
        }
    }
}
