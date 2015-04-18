using UnityEngine;
using System.Collections;

public class ButtonLogic : MonoBehaviour {
	public bool isSelected = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(isSelected){
			if(this.GetComponent<AudioSource>().mute){
				if(Points.points > 0)
					Points.points-= 1;
				else Points.points = 0;
				
			}else{
				Points.points+= 2;
			}
		}else{

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
