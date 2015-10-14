using UnityEngine;
using System.Collections;

public class AutoScaleCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float targetScreen = 4.0f / 3.0f;

		float windowScreen = (float)Screen.width / (float)Screen.height;

		float scaleScreen = windowScreen / targetScreen;

		Camera camera = GetComponent<Camera> ();

		if (scaleScreen < 1.0f) {
			Rect rect = camera.rect;

			rect.width = 1.0f;
			rect.height = scaleScreen;
			rect.x = 0;
			rect.y = (1.0f - scaleScreen) / 2.0f;

			camera.rect = rect;
		} else {
			float scalewidth = 1.0f / scaleScreen;

			Rect rect = camera.rect;

			rect.width = scalewidth;
			rect.height = 1.0f;
			rect.x = (1.0f - scalewidth) / 2.0f;
			rect.y = 0;

			camera.rect = rect;
		}
	}

}
