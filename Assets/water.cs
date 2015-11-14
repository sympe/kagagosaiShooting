using UnityEngine;
using System.Collections;

public class water : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.position.y);
		if(transform.position.y > 9.9f){
			var emitters = transform.GetComponentsInChildren<ParticleEmitter>();
			foreach (var item in emitters){
				item.emit = true;
			}
		}
		else{
			var emitters = transform.GetComponentsInChildren<ParticleEmitter>();
			foreach (var item in emitters){
				item.emit = false;
			}
		}
	}
}
