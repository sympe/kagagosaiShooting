using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {
    int count = 0;
    public GameObject[] Cube;
    public static Vector3[] Position;
    public static Vector3[] Scale;
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
        if (Position == null || Scale == null)
        {
            Position = new Vector3[6];
            Scale = new  Vector3[6];
            for (int j = 0; j < 6; j++)
            {
                Position[j] = Cube[j].transform.position;
                Scale[j] = Cube[j].transform.localScale;
            }
        }
        
        float x, y, z;
        int i;
        z = 0;
        for (i = 0; i < 4; i++)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Enji, new Vector3(x, y, z), Quaternion.identity);
            enji.EnjiCount++;
        }
        for (i = 0; i < 4; i++)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Grass, new Vector3(x, y, z), Quaternion.identity);
            grass.GrassCount++;
        }
        for (i = 0; i < 4; i++)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Indigo, new Vector3(x, y, z), Quaternion.identity);
            indigo.IndigoCount++;
        }
        for (i = 0; i < 4; i++)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Ocher, new Vector3(x, y, z), Quaternion.identity);
            ocher.OcherCount++;
        }
        for (i = 0; i < 4; i++)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Purple, new Vector3(x, y, z), Quaternion.identity);
            purple.PurpleCount++;
        }
        //Cube[count].transform.position = Position[count];
        //Cube[count].transform.localScale = Scale[count];

	}
	
	// Update is called once per frame
	void Update () {
        float x, y, z;
        Vector3 s;
        //s = Cube[count].transform.localScale;
        //s = Scale[count];
        z = 0;
        if (enji.EnjiCount<4)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Enji, new Vector3(x, y, z), Quaternion.identity);
            enji.EnjiCount++;
        }
        if (grass.GrassCount<4)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Grass, new Vector3(x, y, z), Quaternion.identity);
            grass.GrassCount++;
        }
        if (indigo.IndigoCount<4)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Indigo, new Vector3(x, y, z), Quaternion.identity);
            indigo.IndigoCount++;
        }
        if (ocher.OcherCount<4)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Ocher, new Vector3(x, y, z), Quaternion.identity);
            ocher.OcherCount++;
        }
        if (purple.PurpleCount<4)
        {
            x = Random.Range(-16.0f, 16.0f);
            y = Random.Range(-12.0f, 12.0f);
            Instantiate(this.Purple, new Vector3(x, y, z), Quaternion.identity);
            purple.PurpleCount++;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Cube[count].transform.Translate(transform.up * 0.01f);
            Position[count] += new Vector3(0, 0.01f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Position[count] += new Vector3(0,- 0.01f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Position[count] += new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Position[count] += new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Scale[count] += new Vector3(0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Scale[count] += new Vector3(-0.01f, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            Scale[count] += new Vector3(0, 0.01f, 0);
        }
        if (Input.GetKey(KeyCode.R))
        {
            Scale[count] += new Vector3(0, -0.01f, 0);
        }
        Cube[count].transform.position = Position[count];
        //Debug.Log("p " + Cube[count].transform.position + " static " + Position[count]);
        Cube[count].transform.localScale = Scale[count];

        for (int i=0; i < 6; i++)
        {
            Cube[i].transform.localScale = Scale[i];
            Cube[i].transform.position = Position[i];
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (count == 5)
            {
                count = 0;
            }
            else
            {
                count++;
            }
            //s = Cube[count].transform.localScale;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Application.LoadLevel("promapnonkinect");
        }
        if(Input.GetKeyDown(KeyCode.B)){
                Application.LoadLevel("promapkinect");
        }
        if(Input.GetKeyDown(KeyCode.C)){
            Application.LoadLevel("StartScene");
        }
        //Cube[count].transform.localScale = s;
        
	}
}
