using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	public float playerSpeed = 5.0f;
	 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	float transV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
	float transH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
	transform.Translate(new Vector3(transH,transV));
	}
}
