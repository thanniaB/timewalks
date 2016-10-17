using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	public static bool openDoor;
	private bool isDoorClosed;

	// Use this for initialization
	void Start () {
		openDoor = false;
		isDoorClosed = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (openDoor && isDoorClosed) {
			Transform doorClosedNode = transform.GetChild (0);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play ();
			SpriteRenderer doorSprite = doorClosedNode.GetComponent<SpriteRenderer> ();
			doorSprite.enabled = false;
			isDoorClosed = false;
		}
	
	}
}
