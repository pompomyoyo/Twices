using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float touchScreenWidth = Screen.width / 2.0f;
	private Rigidbody2D rb;
	public float rotateSpeed = 10f;
	
	void Update(){
		/*transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
		if (Input.GetTouch(0).phase == TouchPhase.Began) {

			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			if (touchDeltaPosition.x < touchScreenWidth){
				Debug.Log("partie gauche");
			}

			if (touchDeltaPosition.x > touchScreenWidth && touchDeltaPosition.x < (touchScreenWidth * 2)){
				Debug.Log("Partie droite");
			}
		}*/
		
		if (Input.GetKey(KeyCode.D)) {
			transform.Rotate(-Vector3.forward, rotateSpeed * Time.deltaTime,Space.Self);
		}
		if (Input.GetKey(KeyCode.Q)) {
			transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
			/*Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			if (touchDeltaPosition.x < touchScreenWidth){
				Debug.Log("partie gauche");
			}

			if (touchDeltaPosition.x > touchScreenWidth && touchDeltaPosition.x < (touchScreenWidth * 2)){
				Debug.Log("Partie droite");
			}*/
		}
	}
}
