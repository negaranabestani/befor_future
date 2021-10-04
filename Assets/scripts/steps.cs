using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steps : MonoBehaviour {
	public GameObject playerfeet;
	Collider2D colli;
	// Use this for initialization
	void Start () {
		colli = GetComponent<Collider2D> ();
	}
	private void OnTriggerEnter2D ( Collider2D colcoin)
	{
		if (colcoin == playerfeet) {
			colli.isTrigger = false;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
