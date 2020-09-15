using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getstringdata : MonoBehaviour {


	public string goo;
	public string goo2;
	public string goo3;
	public string goo4;
	public string goo5;
	public string goo6;
	public string goo7;
	public string goo8;
	public string goo9;
	public string goo10;
	public string goo11;
	public string goo12;
	public string goo13;
	public string goo14;
	public string goo15;
	public string goo16;
	public string goo17;
	public string goo18;
	//public string goo9;
	//public string goo10;
	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame

	void OnGUI(){

		GUI.contentColor = Color.grey;

		goo = GameObject.Find("Planet01").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 180, 500, 900), goo);

		goo2 = GameObject.Find("Planet02").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 220, 500, 900), goo2);

		goo3 = GameObject.Find("Planet03").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 260, 500, 900), goo3);

		goo4 = GameObject.Find("Planet04").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 300, 500, 900), goo4);

		goo5 = GameObject.Find("Planet05").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 340, 500, 900), goo5);

		goo6 = GameObject.Find("Planet06").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 380, 500, 900), goo6);

		goo7 = GameObject.Find("Planet07").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 420, 500, 900), goo7);

		goo8 = GameObject.Find("Planet08").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 460, 500, 900), goo8);

		goo9 = GameObject.Find("Planet09").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Position.ToString() ;

		GUI.Label(new Rect(20, 500, 500, 900), goo9);

		goo10 = GameObject.Find("Planet01").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 180, 500, 900), goo10);



		goo11 = GameObject.Find("Planet02").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 220, 500, 900), goo11);
	

	goo12 = GameObject.Find("Planet03").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

	GUI.Label(new Rect(400, 260, 500, 900), goo12);

	goo13 = GameObject.Find("Planet04").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

	GUI.Label(new Rect(400, 300, 500, 900), goo13);


		goo14 = GameObject.Find("Planet05").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 340, 500, 900), goo14);

		goo15 = GameObject.Find("Planet06").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 380, 500, 900), goo15);

		goo16 = GameObject.Find("Planet07").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 420, 500, 900), goo16);

		goo17 = GameObject.Find("Planet08").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 460, 500, 900), goo17);

		goo18 = GameObject.Find("Planet09").gameObject.GetComponent<SimpleKeplerOrbits.KeplerOrbitMover> ().OrbitData.Velocity.ToString() ;

		GUI.Label(new Rect(400, 500, 500, 900), goo18);


}
	void Update () {




	}
}
