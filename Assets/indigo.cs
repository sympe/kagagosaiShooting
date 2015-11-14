using UnityEngine;
using System.Collections;

public class indigo : MonoBehaviour {
    float x, y, z;
    public static int IndigoCount=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 center = new Vector3(0, 0, 0) ;
        if (Vector3.Distance(center, transform.position) < 15)
        {
            x = Random.Range(-2.0f, 2.0f);
            y = Random.Range(-2.0f, 2.0f);
            Vector3 p = new Vector3(x, y, z);

            rigidbody.AddForce(5f * p);
        }
        else
        {
            rigidbody.AddForce(0.005f * center - transform.position);
        }
	}
    //void OnTriggerEnter(Collision collision)
    //{
       
    //    if (collision.gameObject.CompareTag("Sphere"))
    //    {
    //        Debug.Log("hey");
    //        Destroy(gameObject);
    //        Destroy(collision.gameObject);
    //        //GameObject firewoks = (GameObject)Instantiate(Fireworks, transform.position, Quaternion.identity);
    //    }
    //}
}
