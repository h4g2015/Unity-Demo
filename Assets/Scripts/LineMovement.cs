using UnityEngine;
using System.Collections;

public class LineMovement : MonoBehaviour {
	private float startPosition = 4.8f;
	private float finishPosition = -4.05f;
	private float speed = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= finishPosition){
			transform.position = new Vector2(startPosition,0);
		}
		transform.Translate(Vector2.up * Time.deltaTime * speed);

	}
}
