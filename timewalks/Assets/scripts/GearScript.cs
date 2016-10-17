using UnityEngine;
using System.Collections;

public class GearScript : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D other) 
	{
		GameObject o = other.gameObject;
		if(o.CompareTag ("gear"))
		{
			DoorScript.openDoor = true;
		}

	}
}
