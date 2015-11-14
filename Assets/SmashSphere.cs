using UnityEngine;
using System.Collections;

public class SmashSphere : MonoBehaviour {
    public GameObject RightHand;
    public GameObject RightElbow;
    public GameObject Sphere;
    Vector3 pos = new Vector3(0f, 0f, 0f);
    public static Vector3 v = new Vector3(0f, 0f, 0f);
    int count=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        v = RightHand.transform.position - RightElbow.transform.position;
        //Sphere.transform.rigidbody.AddForce(0, 0, 6);
        count++;
        pos = RightHand.transform.position;
        if (count > 10)
        {
            Instantiate(Sphere, pos, Sphere.transform.rotation);
            count = 0;
        }
	}
}
