using UnityEngine;
using System.Collections;

public class EndScript : MonoBehaviour {
	public static SpriteRenderer endsprite;
	// Use this for initialization
	void Start () {
		endsprite = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
}
