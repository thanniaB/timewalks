using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public Animator MyAnimator;
	public float speed;
	protected bool isFacingLeft;
	private Rigidbody2D rigidBodyComponent;

	// Use this for initialization
	void Start () {
		MyAnimator = GetComponent<Animator>();
		isFacingLeft = false;
		rigidBodyComponent = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		HandleMovement ();
	}

	void OnCollisionEnter2D(Collision2D other) 
	{
		GameObject o = other.gameObject;
		if(o.CompareTag ("manecilla"))
		{
			rigidBodyComponent.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
		}

		if (o.CompareTag ("door")) {
			if (DoorScript.openDoor) {
				this.GetComponent<SpriteRenderer> ().enabled = false;
				EndScript.endsprite.enabled = true;
			}
		}

	}

	public void HandleMovement () {
		float horizontal = Input.GetAxis ("Horizontal");
		Run (horizontal);
	}

	public void Run(float horizontal) {
		MyAnimator.SetBool("isRunning", horizontal != 0);
		Flip (horizontal);
		if (horizontal != 0) {
			rigidBodyComponent.velocity = new Vector2 (horizontal * speed, rigidBodyComponent.velocity.y);
		}
	}

	public void ChangeDirection()
	{
		isFacingLeft = !isFacingLeft;
		transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y * 1, transform.localScale.z * 1);
	}

	private void Flip(float horizontal)
	{
		if (horizontal > 0 && isFacingLeft || horizontal < 0 && !isFacingLeft)
		{
			ChangeDirection();
		}
	}

}
