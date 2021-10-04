using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
	public string scenename;
	private float speed = 2f;
	private Vector2 gameobjectpos;
	private Rigidbody2D myrigid;
	public float rcolli=0.1f;
	public LayerMask whatisground;
	bool checkcolli=false;
	public GameObject player;
	private int numjump = 0;
	Animator staphinanim;
	Vector3 staphinscale;
	bool clicked=true;
	public bool walkR;
	public bool walkL;
	bool isjumping=false;
	public bool existfine;
	public GameObject fine;
	public bool existtable;
	colliground movetable;
	public GameObject table;
	public static int state=1;
	// Use this for initialization
	void Start () {
		gameobjectpos = transform.position;
		myrigid = GetComponent<Rigidbody2D> ();
		staphinanim = GetComponent<Animator> ();
		staphinscale = transform.localScale;
		if(existtable==true)
		movetable = table.GetComponent<colliground> ();
	}
	void jumper(){
		isjumping = false;
	}

	void moveplayer(){
		if (isjumping == true) {
			Invoke ("jumper", 1.24f);

		}


		checkcolli = Physics2D.OverlapCircle(player.transform.position,rcolli,whatisground);
		if (checkcolli)
			numjump = 0;
		if (Input.GetKey (KeyCode.UpArrow) && numjump == 0) {
			numjump=1;
			myrigid.velocity = new Vector2 (0, 8);
			staphinanim.SetInteger ("state", 3);
			isjumping = true;

		}
		else if (isjumping == false) {
			staphinanim.SetInteger ("state", 1);

		}


		RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.down);
		if (Input.GetMouseButtonDown (0)) {
			gameobjectpos = (Vector2)Camera.main.ScreenToWorldPoint (Input.mousePosition);
			clicked = true;
		}
		if (transform.position.x < gameobjectpos.x && clicked==true&& isjumping==false) {
			transform.position += new Vector3 (Mathf.Abs (gameobjectpos.x), 0).normalized * speed * Time.deltaTime;
			staphinanim.SetInteger("state",2);
			transform.localScale = new Vector2 (staphinscale.x, staphinscale.y);
			walkR = true;
			if (existfine == true) {
				fine.transform.position += new Vector3 (Mathf.Abs (gameobjectpos.x), 0).normalized * Time.deltaTime;

			}
			if (transform.position.x > gameobjectpos.x) {
				clicked = false;
				walkR = false;
				if(existtable==true)
					movetable.clicked = false;
			}

		}

		if (transform.position.x > gameobjectpos.x && clicked==true&& isjumping==false) {
			transform.position -= new Vector3 (Mathf.Abs (gameobjectpos.x), 0).normalized * speed * Time.deltaTime;
			staphinanim.SetInteger("state",2);
			transform.localScale = new Vector2 (-staphinscale.x, staphinscale.y);
			walkL = true; 
			if (existfine == true) {
				fine.transform.position -= new Vector3 (Mathf.Abs (gameobjectpos.x), 0).normalized * Time.deltaTime;

			}
			if (transform.position.x < gameobjectpos.x) {
				clicked = false;
				walkL = false;
				if(existtable==true)
					movetable.clicked = false;

			}

		}
		if (clicked == false&& isjumping==false) {
			staphinanim.SetInteger("state",1);
		}
		
	}
	void OnMouseDown(){
		state = 1;
	}
	// Update is called once per frame
	void Update () {
		print (state);
		if (state == 1) {
			moveplayer ();
		}
		else
			staphinanim.SetInteger("state",1);

	}
}
