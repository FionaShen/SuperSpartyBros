using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// destroy bullet object when hit enemy
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Enemy") {
			Destroy (gameObject);
		}
	}
}
