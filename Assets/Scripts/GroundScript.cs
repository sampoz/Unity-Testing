using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTouchDown( Vector3 hit ) {
		Vector3 towardsPlayer = hit - player.transform.localScale;
		player.TouchController.MoveTowards(towardsPlayer);
	}
}
