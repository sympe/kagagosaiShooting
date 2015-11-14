using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
    float x=0f, y=0f, z=0f;
    Material texture1;
    Material texture2;
    Material texture3;
    public float Speed = 1f;
    int colorcount=0;
	// Use this for initialization
	void Start () {
        //texture1 = (Material)Resources.Load("Wooden tile Mat");
        //texture2 = (Material)Resources.Load("Bricks red rough Mat");
        //texture3 = (Material)Resources.Load("Bricks rough Mat");
	}
	
	// Update is called once per frame
	void Update () {
        //var v = new Vector3(0.5f, 0.5f, 0);
        //transform.Rotate(v);
        //if ((-5f< x&& x < 5f) || (-5f<y&& y < 5f))
        //{
        Vector3 center = new Vector3(0, 0, 3) - transform.position;
        if (Vector3.Distance(center, transform.position) < 30)
        {
            x = Random.Range(-4.0f, 4.0f);
            y = Random.Range(-4.0f, 4.0f);
            //}
            Vector3 p = new Vector3(x, y, z);
            //this.transform.Translate(p);
           
            //if (p.magnitude == 0) p = 0.0001f * Vector3.one;

            rigidbody.AddForce(4f * Speed * p);
        }
        else
        {
            rigidbody.AddForce(0.1f * center);
        }
        //if (count >= 40)
        //{
        //    count = 0;
        //    x *= -1;
        //    y *= -1;
        //}
	}
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Spehere"))
        {
            Destroy(collision.gameObject);
            if (colorcount == 0)
            {
                gameObject.renderer.material.color = Color.red;
                //renderer.material = texture1;
                colorcount++;
            }
            else if (colorcount == 1)
            {
                gameObject.renderer.material.color = Color.green;
                //renderer.material = texture2;
                colorcount++;
            }
            else
            {
                gameObject.renderer.material.color = Color.blue;
                //renderer.material = texture3;
                colorcount=0;
            }
        }
    }
}
