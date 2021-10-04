using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class getcoin : MonoBehaviour
{
	public bool getkey = false;
    Button  barobj;
	private Transform placecol;
	private bool click;
	private Rigidbody2D myrigid;
	public GameObject player;
	private lamp lamp;
	public Button buttonbar;
	public Transform firstbuttonbarpos;
	Vector2 buttonbarpos;
	public GameObject bar;
	public Sprite buttonbarimage;
	public static int buttonbarcount = 1;
	public bool parted;
	public GameObject partofob;
	usebar useb;
	public int selectcount;
	public bool mergable;
	bool created=false;

	public SpriteRenderer usbsphand;
	public GameObject usbhand;
	public GameObject usbstaphin;
	merege mrg;
	public Sprite mergedbuttonsprite;
	ButtonScript buttscip;
	void Start () 
	{
		lamp = player.GetComponent<lamp> ();
		myrigid =player.GetComponent <Rigidbody2D> ();

	}

	void Update () 
	{
		buttonbarcount = bar.transform.childCount;
	}
	void OnMouseDown(){
		click = true;

	}
	private void OnTriggerEnter2D ( Collider2D colcoin)
	{
		if (colcoin.name == "staphin"&&click==true) {
			if (parted == true) {
				if (partofob != null) {
					Destroy (partofob);
					created = true;
					buttonbarpos.x = firstbuttonbarpos.transform.position.x + (buttonbarcount) * 12 / 10; 
					buttonbarpos.y = firstbuttonbarpos.transform.position.y;
					barobj = Instantiate (buttonbar, buttonbarpos, Quaternion.identity);
					barobj.transform.parent = bar.transform;
					barobj.GetComponent<Image> ().sprite = buttonbarimage;
					barobj.transform.localScale = new Vector2 (1, 1);
					//buttonbarcount++;
					buttscip = barobj.GetComponent<ButtonScript> ();
					buttscip.created =true;

						useb = barobj.GetComponent<usebar> ();
						mrg = barobj.GetComponent<merege> ();
					    buttscip.usbismerging = mergable;
					    buttscip.mrgselectcount = selectcount;
					    buttscip.usbhand = usbhand;
					    buttscip.usbsphand = usbsphand;
					    buttscip.usbstaphin = usbstaphin;
					    buttscip.mrgbuttonbar = buttonbar;
					    buttscip.mrgbar = bar;
					    buttscip.mrgmergedbuttonsprite = mergedbuttonsprite;
					    buttscip.mrgfirstbuttonbarpos = firstbuttonbarpos;
					    buttscip.mrgcount = buttonbarcount;

				}
				 else
					print ("oo");
			}
			else {
				Destroy (this.gameObject);
				buttonbarpos.x = firstbuttonbarpos.transform.position.x + (buttonbarcount) * 12 / 10; 
				buttonbarpos.y = firstbuttonbarpos.transform.position.y;
				barobj = Instantiate (buttonbar, buttonbarpos, Quaternion.identity);
				barobj.transform.parent = bar.transform;
				barobj.GetComponent<Image> ().sprite = buttonbarimage;
				barobj.transform.localScale = new Vector2 (1, 1);
				//buttonbarcount++;
				buttscip = barobj.GetComponent<ButtonScript> ();
				buttscip.created =true;

					useb = barobj.GetComponent<usebar> ();
					mrg = barobj.GetComponent<merege> ();
				buttscip.usbismerging = mergable;
				buttscip.mrgselectcount = selectcount;
				buttscip.usbhand = usbhand;
				buttscip.usbsphand = usbsphand;
				buttscip.usbstaphin = usbstaphin;
				buttscip.mrgbuttonbar = buttonbar;
				buttscip.mrgbar = bar;
				buttscip.mrgmergedbuttonsprite = mergedbuttonsprite;
				buttscip.mrgfirstbuttonbarpos = firstbuttonbarpos;
				buttscip.mrgcount = buttonbarcount;



			}
		}





	}


}


