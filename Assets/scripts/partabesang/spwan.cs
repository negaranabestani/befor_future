using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour {

	public GameObject birdprefab;
	bool occupied = false;
    GameObject prop;
    public GameObject bk;
    int i = 0; 
    Rigidbody2D rb;
	void spawnnext(){
        i++;
		prop=Instantiate (birdprefab, transform.position, Quaternion.identity);
		occupied = true;
        prop.transform.parent = bk.transform;
	}

	void OnTriggerExit2D(Collider2D co){
        if (occupied)
        {
            occupied = false;
           // occupied = true;
        }
	}

	bool scenemoving(){
        //Rigidbody2D[] bodies = FindObjectsOfType (typeof(Rigidbody2D))as Rigidbody2D[];
        rb = birdprefab.GetComponent<Rigidbody2D>();
        if (rb.velocity.sqrMagnitude>5)
                return true;
		return false;
	}


	void 	FixedUpdate (){
		if (occupied==false)
			spawnnext ();
	//	print (occupied);

	
	}
}
