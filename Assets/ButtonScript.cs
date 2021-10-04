using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {
	public bool created=false;
	public bool iscreated=false;
	public bool usbismerging;
	public int mrgselectcount;
	public GameObject usbhand ;
	public SpriteRenderer usbsphand;
	public GameObject usbstaphin;
	public Button mrgbuttonbar;
	public GameObject mrgbar;
	public Sprite mrgmergedbuttonsprite;
	public Transform mrgfirstbuttonbarpos;
	public int mrgcount;
	public bool sened = false;
	usebar usb;
	merege mrg;
	ButtonScript mrgbarobj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (created == true) {
			gameObject.AddComponent<usebar> ();
			gameObject.AddComponent<merege> ();
			iscreated = true;
			created = false;
		}
		if (iscreated == true) {
			usb=gameObject.GetComponent<usebar> ();
			mrg=gameObject.GetComponent<merege> ();
			usb.ismerging = usbismerging;
			mrg.selectcount =mrgselectcount;
			usb.hand = usbhand;
			usb.sphand = usbsphand;
			usb.staphin = usbstaphin;
			mrg.bar = mrgbar;
			mrg.buttonbar = mrgbuttonbar;
			mrg.mergedbuttonsprite = mrgmergedbuttonsprite;
			mrg.firstbuttonbarpos = mrgfirstbuttonbarpos;
			mrg.count = mrgcount;

		}
		if (mrg.isameregedbutton == true) {
			mrgbarobj = mrg.barobj.GetComponent<ButtonScript> ();
			mrgbarobj.usbismerging = false;
			//mrgbarobj.mrgselectcount = mrgselectcount;
			mrgbarobj.usbhand = usbhand;
			mrgbarobj.usbsphand = usbsphand;
			mrgbarobj.usbstaphin = usbstaphin;
			usb.ismerging = false;
			sened = true;
			//mrgbarobj.mrgbuttonbar = mrgbuttonbar;
			//mrgbarobj.mrgbar = mrgbar;
			//mrgbarobj.mrgmergedbuttonsprite = mrgmergedbuttonsprite;
			//mrgbarobj.mrgfirstbuttonbarpos = mrgfirstbuttonbarpos;
			//mrgbarobj.mrgcount =mrgcount;
		}

	}
	public void OnButtonClick(){
		
	}
}
