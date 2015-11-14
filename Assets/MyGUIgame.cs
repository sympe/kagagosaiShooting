using UnityEngine;
using System.Collections;

public class MyGUIgame : MonoBehaviour {
    int count = 0;
    public GameObject[] Cube;
    int maxtime = 15;
    public float timer = 0;
    public static int score = 0;
    //public static int scene = 1;
    //public GameObject fire;
    public GameObject Sphere;
    public GameObject Enji;
    public GameObject Grass;
    public GameObject Indigo;
    public GameObject Ocher;
    public GameObject Purple;
    private Vector3 clickPosition;
	// Use this for initialization
	void Start () {
        float x, y, z;
        enji.EnjiCount = 0;
        grass.GrassCount = 0;
        indigo.IndigoCount = 0;
        ocher.OcherCount = 0;
        purple.PurpleCount = 0;
        int i;
        z = 0;
        for (i = 0; i < 1; i++)
        {
            x = Random.Range(-6.0f, 6.0f);
            y = Random.Range(-6.0f, 6.0f);
            Instantiate(this.Enji, new Vector3(x, y, z), Quaternion.identity);
            enji.EnjiCount++;
        }
        for (i = 0; i < 3; i++)
        {
            x = Random.Range(-7.0f, 7.0f);
            y = Random.Range(-4.0f, 7.0f);
            Instantiate(this.Grass, new Vector3(x, y, z), Quaternion.identity);
            grass.GrassCount++;
        }
        for (i = 0; i < 7; i++)
        {
            x = Random.Range(-11.0f, 11.0f);
            y = Random.Range(-4.0f, 9.0f);
            Instantiate(this.Indigo, new Vector3(x, y, z), Quaternion.identity);
            indigo.IndigoCount++;
        }
        for (i = 0; i < 5; i++)
        {
            x = Random.Range(-14.0f, 14.0f);
            y = Random.Range(-4.0f, 10.0f);
            Instantiate(this.Ocher, new Vector3(x, y, z), Quaternion.identity);
            ocher.OcherCount++;
        }
        for (i = 0; i < 9; i++)
        {
            x = Random.Range(-14.0f, 14.0f);
            y = Random.Range(-4.0f, 10.0f);
            Instantiate(this.Purple, new Vector3(x, y, z), Quaternion.identity);
            purple.PurpleCount++;
        }

	}
	
	// Update is called once per frame
	void Update () {
        float x, y, z;
        //Vector3 s;
        //s = Cube[count].transform.localScale;
        if (timer > maxtime)
        {
            timer = 0;
            Application.LoadLevel("EndScene");
        }
        timer += Time.deltaTime;
        
        
        if (enji.EnjiCount<1)
        {
            x = Random.Range(-8f, 8f);
            y = Random.Range(12f, 14f);
            z = 0;
            Instantiate(this.Enji, new Vector3(x, y, z), Quaternion.identity);
            enji.EnjiCount++;
        }
        if (grass.GrassCount<3)
        {
            x = Random.Range(7f, 9f);
            y = Random.Range(1f, 5f);
            z = 0;
            Instantiate(this.Grass, new Vector3(x, y, z), Quaternion.identity);
            grass.GrassCount++;
        }
        if (indigo.IndigoCount<7)
        {
            x = Random.Range(-2f, 8f);
            y = Random.Range(2f, 8f);
            z = 0;
            Instantiate(this.Indigo, new Vector3(x, y, z), Quaternion.identity);
            indigo.IndigoCount++;
        }
        if (ocher.OcherCount<5)
        {
            x = Random.Range(-2f, 8f);
            y = Random.Range(2f, 8f);
            z = 0;
            Instantiate(this.Ocher, new Vector3(x, y, z), Quaternion.identity);
            ocher.OcherCount++;
        }
        if (purple.PurpleCount<9)
        {
            x = Random.Range(-2f, 8f);
            y = Random.Range(2f, 8f);
            z = 0; 
            Instantiate(this.Purple, new Vector3(x, y, z), Quaternion.identity);
            purple.PurpleCount++;
        }
        for (int i = 0; i < 6; i++)
        {
            Cube[i].transform.localScale =MyGUI.Scale[i];
            Cube[i].transform.position =MyGUI.Position[i];
        }
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    Cube[count].transform.Translate(transform.up * 0.01f);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    Cube[count].transform.Translate(transform.up * -0.01f);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Cube[count].transform.Translate(transform.right * 0.01f);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Cube[count].transform.Translate(transform.right * -0.01f);
        //}
        
        //if(Input.GetKeyDown(KeyCode.T))
        //{
        //    if (count == 5)
        //    {
        //        count = 0;
        //    }
        //    else
        //    {
        //        count++;
        //    }
        //    s = Cube[count].transform.localScale;
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    if (scene == 1)
        //    {
        //        Application.LoadLevel("promapkinect");
        //        scene = 2;
        //    }
        //    else if (scene == 2)
        //    {
        //        Application.LoadLevel("promapnonkinect");
        //        scene = 1;
        //    }
        //}
        //Cube[count].transform.localScale = s;
        
        
        //Debug.Log("hey!");
        //float x=1f,y=2f,z=0f;
        //int counter=0;
        //counter++;
        //Vector3 p = new Vector3(x, y, z);
        //cube.transform.Translate(p);
        //if (counter >= 40)
        //{
        //    counter = 0;
        //    x *= -1;
        //    y *= -1;
        //}
        //count++;
        //if (count > 100) /*cubecount < 5*/
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
        //    Instantiate(Sphere, Camera.main.ScreenToWorldPoint(clickPosition), Sphere.transform.rotation);
        //}
	}
}
