using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	public Transform target;
	int distance = -10;
	float lift = 1.5f;
	void Update(){
         transform.position = new Vector3(0,lift,distance)+ target.position;
         transform.LookAt(target);
	}
}
