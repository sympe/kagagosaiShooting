using UnityEngine;
using System.Collections;

public class spherescriptgame : MonoBehaviour {
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
    //Vector3 v = new Vector3(0f, 0f, 0f);
    //public GameObject Target;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //v = RightHand.transform.position - RightElbow.transform.position;
        transform.rigidbody.AddForce(15*SmashSphere.v);
        
        if (transform.position.z > 25)
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
            MyGUIgame.score += 5000;
        }
        if (collision.gameObject.CompareTag("Grass"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            grass.GrassCount--;
            GameObject particlegrass = (GameObject)Instantiate(ParticleGrass, transform.position, Quaternion.identity);
            MyGUIgame.score += 2000;
        }
        if (collision.gameObject.CompareTag("Ocher"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            ocher.OcherCount--;
            GameObject particleocher = (GameObject)Instantiate(ParticleOcher, transform.position, Quaternion.identity);
            MyGUIgame.score += 1500;
        }
        if (collision.gameObject.CompareTag("Indigo"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            indigo.IndigoCount--;
            GameObject particleindigo = (GameObject)Instantiate(ParticleIndigo, transform.position, Quaternion.identity); ;
            MyGUIgame.score += 1000;
        }
        if (collision.gameObject.CompareTag("Purple"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            purple.PurpleCount--;
            GameObject particlepurple = (GameObject)Instantiate(ParticlePurple, transform.position, Quaternion.identity);
            MyGUIgame.score += 500;
        }
        //if (collision.gameObject.CompareTag("Cube"))
        //{
        //    GameObject particle = (GameObject)Instantiate(Particle, transform.position, Quaternion.identity);
        //}
    }
}
