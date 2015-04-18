using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public GameObject [] buttons = new GameObject[4];
	private int selected = 0;
	private float timer = 0;
	public float trackTime;

	// Use this for initialization
	void Start () {
		foreach(GameObject obj in buttons){
			obj.GetComponent<AudioSource>().mute = true;
		}
		StartCoroutine("ChangeTrack");
		//this.GetComponent<AudioSource>().Play();
		/*
		 * controlar evento de cuando se matiene pulsado un boton
		 * 
		 * actualizar puntuacion con el boton pulsado
	*/
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(timer > trackTime){
			end();
			StopCoroutine("ChangeTrack");
		}
	}

	void end(){

	}
	IEnumerator ChangeTrack() {
		while(true){
			Debug.Log("yea");
			muteTrack(true);
			selected = Random.Range(0,buttons.Length);
			muteTrack(false);
			//Debug.Log(selected);
			yield return new WaitForSeconds(5);
		}
	}

	void muteTrack(bool mute){
		buttons[selected].GetComponent<AudioSource>().mute = mute;
	}
}
