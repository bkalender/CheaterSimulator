using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public Transform from;
	public Transform to;
	public float speed;
	void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.rotation = Quaternion.Euler (-20, 27, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
		{
			transform.rotation = Quaternion.Euler (-20, -27, 0);
		}
		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.rotation = Quaternion.Euler (-10, -115, 0);
		}
		if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
		{
			transform.rotation = Quaternion.Euler (-10, 115, 0);
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}
}