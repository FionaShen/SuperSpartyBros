using UnityEngine;
using System.Collections;

public class PlatformMoverChild : MonoBehaviour {

	// invoke the collision on parent
	void OnCollisionEnter2D( Collision2D collision) {
		GetComponent<Collider2D>().GetComponentInParent<PlatformMover> ().OnCollisionEnter2D (collision);
	}
}
