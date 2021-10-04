using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;


public class pullrelease : MonoBehaviour {
	Vector2 startPos;
    public float force = 1300;
    public float rcolli = 0.1f;
    public LayerMask whatisground;
    bool checkcolli = false;
	static int hited=0;
	public GameObject liptooshousedoor;
	public GameObject liptooskeyhome;
	public GameObject hitarea;
	public GameObject crack;
	public GameObject crackcenter;
	public GameObject brokenwindow;


	// Use this for initialization
	void Start () {
		startPos = transform.position;

	}

	private void OnTriggerEnter2D ( Collider2D colcoin)
	{
		if (colcoin.name == hitarea.name) {
			crack.SetActive (true);
			hitarea.SetActive(false);
			//crackcenter.SetActive (true);
			hited++;
		}
		else if (colcoin.name == crack.name) {
			crack.SetActive (false);

			brokenwindow.SetActive (true);
			liptooskeyhome.SetActive (true);
		}


	}
    void FixedUpdate() {
		
		
       // if (gameObject.GetComponent<SpriteRenderer>().IsVisibleFrom(Camera.main) == false )
           // Destroy(gameObject);
        checkcolli = Physics2D.OverlapCircle(transform.position, rcolli, whatisground);
       // if (checkcolli)
           // Destroy(gameObject);
		/*if (hited == 2) {
			liptooskeyhome.SetActive (true);
		}*/
    }

    void OnMouseUp(){
        // Disable isKinematic
        GetComponent<Rigidbody2D>().isKinematic = false;

        // Add the Force
        Vector2 dir = startPos - (Vector2)transform.position;
        GetComponent<Rigidbody2D>().AddForce(dir * force);

        // Remove the Script (not the gameObject)
      //  Destroy(this);

	}

	public void OnMouseDrag(){
		controller.state = 2;
		//print ("ah");
//	GetComponent<Rigidbody2D> ().isKinematic = false;
		Vector2 p = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float radius = 1.5f;
		Vector2 dir = p - startPos;
		if (dir.sqrMagnitude > radius*5.1f)
			dir = dir.normalized * radius;
		transform.position = startPos + dir;
	}
}
