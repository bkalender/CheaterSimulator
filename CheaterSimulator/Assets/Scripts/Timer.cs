using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	float timer = 90.0f;
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			timer = 0;
		}
	}

	void OnGUI()
	{
		GUI.Box (new Rect (250, 10 , 50, 20), "" + timer.ToString ("0"));
	}
}
