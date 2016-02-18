using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	// prevent player from moving to the boundaries
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player") {
			CharacterController2D playerController = collision.GetComponent<CharacterController2D> ();
			playerController._rigidbody.velocity = new Vector2 (0, playerController.transform.position.y);
		}
	}
}
