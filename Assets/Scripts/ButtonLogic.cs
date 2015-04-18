using UnityEngine;
using System.Collections;

public class ButtonLogic : MonoBehaviour {
	private GameObject line;
	public bool isSelected = false;
	// Use this for initialization
	void Start () {
		line = GameObject.Find("linea " + this.name);
		Debug.Log(GameObject.Find("linea " + this.name).name);
	}
	
	// Update is called once per frame
	void Update () {
		if(isSelected){
			if(this.GetComponent<AudioSource>().mute){
				if(Points.points > 0)
					Points.points-= 1;
				else Points.points = 0;
				line.GetComponent<SpriteRenderer>().color = Color.red;
				
			}else{
				Points.points+= 2;
				line.GetComponent<SpriteRenderer>().color = Color.green;
			}
		}else{
			line.GetComponent<SpriteRenderer>().color = Color.white;
		}
	}

	public void clickButton(){
		isSelected = true;


		/*if(this.GetComponent<AudioSource>().mute){
			Points.points-= 5;
			line.GetComponent<SpriteRenderer>().color = Color.red;

		}else{
			Points.points+= 15;
			line.GetComponent<SpriteRenderer>().color = Color.green;
		}*/
	}

	public void leaveClick(){
		isSelected = false;
		//line.GetComponent<SpriteRenderer>().color = Color.white;
	
	}


}
