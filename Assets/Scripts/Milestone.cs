using UnityEngine;
using System.Collections;

public class Milestone : MonoBehaviour {

	public GameObject bulletObtainer;

	private Vector3 _bulletObtainerOriginalPos;

	void Start() {
		if (bulletObtainer)
			_bulletObtainerOriginalPos = bulletObtainer.transform.position;
	}

	// reach milestone, if lose life, then change player and bullet respawn position
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player") {
			CharacterController2D playerController = collision.GetComponent<CharacterController2D> ();
			GameManager.gm._playerSpawnLocation = new Vector3 (86, playerController.transform.position.y, playerController.transform.position.z);
			if (bulletObtainer)
				GameManager.gm._bulletSpawnLocation = new Vector3 (107, _bulletObtainerOriginalPos.y, _bulletObtainerOriginalPos.z);
		}
	}
}
