using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class merege : MonoBehaviour {
	static int buttonselected=0;
	public int selectcount;
	public Sprite mergedbuttonsprite;
	public Button  barobj;
	public Button buttonbar;
	public Transform firstbuttonbarpos;
	Vector2 buttonbarpos;
	public GameObject bar;
	public usebar useb;
	getcoin getthings;
	static bool created=false;
	public int count;
	public bool isameregedbutton;
	public bool slingshot;
	ButtonScript butscip;
	int xx=0;
// Use this for initialization
	void Start () {
		useb = GetComponent<usebar> ();
		butscip = GetComponent<ButtonScript> ();
	}
	void OnButtonClick(){
		

	}
	// Update is called once per frame
	void Update () {
		print (count);
		count = bar.transform.childCount;
		if (buttonselected == selectcount&& created==false) {
			buttonbarpos.x = firstbuttonbarpos.transform.position.x+ (count-buttonselected)*12/10; 
			buttonbarpos.y = firstbuttonbarpos.transform.position.y;
			barobj = Instantiate (buttonbar, buttonbarpos, Quaternion.identity);
			barobj.GetComponent<Image> ().sprite =  mergedbuttonsprite;
			barobj.transform.parent = bar.transform ;
			isameregedbutton = true;
			created = true;
			count++;
		}
		if (created == true&& butscip.sened==true) {
			Destroy (gameObject);
			//barobj.transform.localScale = new Vector2 (1, 1);
		}
		buttonselected = useb.numberserlected;
	}
}
