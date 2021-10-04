using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class liptooscntrl : MonoBehaviour {
	private Rigidbody2D myrigid;
	public GameObject player;
	// Use this for initialization
	void Start () {
		myrigid = GetComponent<Rigidbody2D> ();

	}
	public void folower(){
		if(player.IsVisibleFrom(Camera.main))
			SceneManager.LoadScene ("l1s3");
	}
	public void startfalowing(){
		myrigid.velocity = new Vector2 (-8, 0);
		if (gameObject.IsVisibleFrom(Camera.main)==false) {
			Invoke ("folower",10f);
		}
	}
	// Update is called once per frame
	void Update () {
		
		Invoke ("startfalowing",20f);
			
	}
}
