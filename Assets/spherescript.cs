using UnityEngine;
using System.Collections;

public class spherescript : MonoBehaviour {
    //int count = 0;
    //public int cubecount = 0;
    //public GameObject RightHand;
    //public GameObject RightElbow;
    //public GameObject cube;
    public GameObject sphere;
    private Vector3 clickPosition;
    public GameObject ParticleEnji;
    public GameObject ParticleGrass;
    public GameObject ParticleIndigo;
    public GameObject ParticleOcher;
    public GameObject ParticlePurple;
    Vector3 v = new Vector3(0f, 0f, 0f);
    //public GameObject Target;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //v = RightHand.transform.position - RightElbow.transform.position;
        transform.rigidbody.AddForce(15*SmashSphere.v);
        //transform.rigidbody.AddForce(0, 0, 6);
        //count++;
        //if (count > 100 )
        //{
        //    float x = Random.Range(-4.0f, 4.0f);
        //    float y = Random.Range(-4.0f, 4.0f);
        //    float z = 3.0f;
        //    Instantiate(this.cube, new Vector3(x, y, z), Quaternion.identity);
        //    count = 0;
        //}
        //if (Input.GetMouseButtonDown(0))
        //{
        //    clickPosition = Input.mousePosition;
        //    clickPosition.z = 10f;
        //    Instantiate(sphere, Camera.main.ScreenToWorldPoint(clickPosition), sphere.transform.rotation);
        //}
        if (transform.position.z > 30)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enji"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            enji.EnjiCount--;
            GameObject particlenji = (GameObject)Instantiate(ParticleEnji, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Grass"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            grass.GrassCount--;
            GameObject particlegrass = (GameObject)Instantiate(ParticleGrass, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Ocher"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            ocher.OcherCount--;
            GameObject particleocher = (GameObject)Instantiate(ParticleOcher, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Indigo"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            indigo.IndigoCount--;
            GameObject particleindigo = (GameObject)Instantiate(ParticleIndigo, transform.position, Quaternion.identity); ;
        }
        if (collision.gameObject.CompareTag("Purple"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            purple.PurpleCount--;
            GameObject particlepurple = (GameObject)Instantiate(ParticlePurple, transform.position, Quaternion.identity);
        }
        //if (collision.gameObject.CompareTag("Cube"))
        //{
        //    GameObject particle = (GameObject)Instantiate(Particle, transform.position, Quaternion.identity);
        //}
    }
}
