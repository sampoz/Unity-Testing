using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	public PlayerController playerController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTouchDown( Vector3 hit ) {
		playerController.MoveTowards( hit );
	}
}