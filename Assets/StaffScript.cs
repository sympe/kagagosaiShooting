using UnityEngine;
using System.Collections;

public class StaffScript : MonoBehaviour {
    public GameObject RightHand;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.up = SmashSphere.v;
        transform.position = RightHand.transform.position-(0.5f*SmashSphere.v);
	}
}
