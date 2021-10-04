using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetable : MonoBehaviour {
	public float speed = 1.5f;
	public float x=3;
	private Rigidbody2D myrigid;
	public float rcolli=0.1f;
	public Transform ghostcollision;
	public LayerMask whatisground;
	bool checkcolli=false;
	// Use this for initialization
	void Start () {
		myrigid=GetComponent<Rigidbody2D>();
		
	}

		
			






	// Update is called once per frame
	void Update () {
		
	}
	private void FixedUpdate()
	{
		checkcolli = Physics2D.OverlapCircle(ghostcollision.position,rcolli,whatisground);
		if (checkcolli) {
			if (Input.GetKeyDown (KeyCode.RightArrow))
				this.gameObject.transform.position += Vector3.right*speed;
			else if (Input.GetKeyDown (KeyCode.LeftArrow))
				this.gameObject.transform.position -= Vector3.left*speed;
		}

	}
}
