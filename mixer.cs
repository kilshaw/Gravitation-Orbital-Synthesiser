using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class mixer : MonoBehaviour {
	public AudioMixer NewAudioMixer;
	//public AudioMixer delayer;
	public float tester;
	//public float tester2;
	// Use this for initialization
	public float hSliderValue = 0.3F;
	public float hSliderValue2 = -0.0F;
	//public float hSliderValuetest = -0.0F;


	//GUIStyle style;

	void Start () {

	}


	void OnGUI(){
		GUI.contentColor = Color.white;
		GUI.backgroundColor = Color.red;


		//x = GameObject.Find("Planet01").gameObject.GetComponent<KeplerOrbitMover> ().TimeScale ;
		hSliderValue = GUI.HorizontalSlider(new Rect(25, 890, 400, 30), hSliderValue, 0.0F, 10.0F);
		hSliderValue2 = GUI.HorizontalSlider(new Rect(25, 930, 400, 30), hSliderValue2, -10000.0F, 0.0F);
		//hSliderValuetest = GUILayout.HorizontalSlider(hSliderValuetest, 0.0f, 10.0f);

		GUI.Label(new Rect(400, 880, 300, 300), "Pitch ");
		GUI.Label(new Rect(400, 920, 300, 300), "Reverb ");



		GUI.Label(new Rect(25, 970, 300, 300), "Simon Kilshaw 2019 " );
		GUI.Label(new Rect(25, 1000, 300, 300), "Orbit Vector Counterpoint " );


	}




	// Update is called once per frame
	void Update () {

		//tester = GameObject.Find("reader").gameObject.GetComponent<Arduino> ().sensor;
		NewAudioMixer.SetFloat ("pitchshift", hSliderValue * 2 );
		//delayer.SetFloat ("pitchshift2", hSliderValue * 2 );
		NewAudioMixer.SetFloat ("room", hSliderValue2  );

		//tester2 = GameObject.Find("AXIS").gameObject.GetComponent<xboxing> ().y2;
		//masterMixer.SetFloat ("pitcher", tester2 * 3);




	}
}