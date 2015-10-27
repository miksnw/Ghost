using UnityEngine;
using System.Collections;

public class intefacescript : MonoBehaviour {
	public float interfaceVelocity;
	public float boundary;
	private Vector3 interfacePosition;
	// Use this for initialization
	void Start () {
		interfacePosition = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// горизонтальное движение
		interfacePosition.x += Input.GetAxis ("Horizontal")*interfaceVelocity;
		// выход из игры
	
		// обновим позицию интерфейса
		transform.position = interfacePosition;
		if (interfacePosition.x < -boundary) {
			
			transform.position = new Vector3 (-boundary, interfacePosition.y, interfacePosition.z);
		} 
		if (interfacePosition.x > boundary) {
			//if(Input.anyKey){
			//	animation.Play();}
			//	else animation.Stop();
			transform.position = new Vector3(boundary, interfacePosition.y, interfacePosition.z);     
		}
	}
}
