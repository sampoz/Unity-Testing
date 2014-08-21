using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTouchDown( Vector3 hit ) {
		GameObject gos = GameObject.FindWithTag("player"); 
		Debug.Log ("Sending hitpoint " + hit);
		gos.SendMessage ("MoveTowards", hit);
	}
}