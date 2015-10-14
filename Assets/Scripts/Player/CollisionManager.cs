using UnityEngine;
using System.Collections;

public abstract class CollisionManager : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag ("Plateform"))
			OnContactPlateform ();

		if (other.gameObject.CompareTag ("Bonus"))
			OnContactBonus ();
	}

	void OnContactPlateform (){
		Application.LoadLevel (Application.loadedLevel);
		Destroy (gameObject);
	}

	abstract protected void OnContactBonus ();
}
