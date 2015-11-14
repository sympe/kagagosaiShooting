using UnityEngine;
using System.Collections;

public class fireball : MonoBehaviour {
    //int count = 0;
    //int cubecount = 0;
    public GameObject cube;
    public GameObject fire;
    private Vector3 clickPosition;
	// Use this for initialization
	void Start () {
        renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        //count++;
        //if (count > 1000) /*cubecount < 5*/
        //{
        //    float x = Random.Range(-4.0f, 4.0f);
        //    float y = Random.Range(-4.0f, 4.0f);
        //    float z = 3.0f;
        //    Instantiate(this.cube, new Vector3(x, y, z), Quaternion.identity);
        //    //cubecount++;
        //    count = 0;
        //}
        //if (Input.GetMouseButtonDown(0))
        //{
        //    clickPosition = Input.mousePosition;
        //    clickPosition.z = 10f;
        //    Instantiate(fire, Camera.main.ScreenToWorldPoint(clickPosition), fire.transform.rotation);
        //}
	}
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hey");
        if (collision.gameObject.CompareTag("Cube"))
        {
            collision.gameObject.renderer.material.color = Color.yellow;
        }
    }
}
