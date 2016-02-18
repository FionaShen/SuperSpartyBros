using UnityEngine;
using System.Collections;

public class ExtraLifeObtainer : MonoBehaviour {

	public bool taken = false;
	public GameObject explosion;

	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.tag == "Player" ) && (!taken) && (other.gameObject.GetComponent<CharacterController2D>().playerCanMove))
		{
			// mark as taken so doesn't get taken multiple times
			taken = true;

			// if explosion prefab is provide, then instantiate it
			if (explosion)
			{
				Instantiate(explosion,transform.position,transform.rotation);
			}

			// add extra life to player
			GameManager.gm.addLife (1);

			// destroy the gameobject
			DestroyObject(this.gameObject);
		}
	}
}
