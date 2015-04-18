using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Points : MonoBehaviour {
	public static int points;
	private Text text;
	// Use this for initialization
	void Start () {
		text = this.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "" + points;
	}
}
