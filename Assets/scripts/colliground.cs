using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliground : MonoBehaviour
{
	private float speed=1.5f;
	public float x=3;
	private Rigidbody2D myrigid;
	controller control;
	public Transform endd;
	public GameObject staphin;
	public bool clicked;


	void Start ()
  {
		myrigid=GetComponent<Rigidbody2D>();
		control = staphin.GetComponent<controller> ();

	}
	void OnMouseDown(){
		clicked = true;
	}

	void Update ()
  {

	}
	private void OnTriggerEnter2D ( Collider2D colcoin){
		if (colcoin.name == "staphin") {
			if(control.walkR==true&&clicked==true){
				this.gameObject.transform.position += 6*(Vector3.right) * speed * Time.deltaTime;
			}
			else if(control.walkL==true&&clicked==true){
					this.gameObject.transform.position += 6*(Vector3.left )* speed * Time.deltaTime;
				
			}
		}
	}
	private void FixedUpdate()
	{

	}
}
