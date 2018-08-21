using UnityEngine;
using System.Collections;

public class TeacherScript : MonoBehaviour {
	// Use this for initialization
	int direcion;
	Vector3 speed = new Vector3 (0, 0, 0.03f);
	int randomNumber;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += speed;

	}
	void OnTriggerEnter (Collider coll) {
		if (coll.tag.Equals ("DirectionPoints")){
			direcion = coll.GetComponent<DirectionObjects> ().directionPoint;
			if (direcion == 0){
				randomNumber = Random.Range (1, 3);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				else if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
			}
			if (direcion == 1){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 2){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 3){
				randomNumber = Random.Range (1, 3);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 4){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
			}
			if (direcion == 5){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 6){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
			}
			if (direcion == 7){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
					speed = new Vector3 (0, 0, -0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 8){
				randomNumber = Random.Range (1, 3);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
			}
			if (direcion == 9){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 10){
				randomNumber = Random.Range (1, 4);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
					speed = new Vector3 (0.03f, 0, 0);
				}
				if (randomNumber == 3) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
			if (direcion == 11){
				randomNumber = Random.Range (1, 3);
				if (randomNumber == 1) {
					gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
					speed = new Vector3 (0, 0, 0.03f);
				}
				if (randomNumber == 2) {
					gameObject.transform.rotation = Quaternion.Euler (0, -90, 0);
					speed = new Vector3 (-0.03f, 0, 0);
				}
			}
				
	}
	}
}
