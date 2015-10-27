using UnityEngine;
using System.Collections;

public class fixedcamera : MonoBehaviour {



	public float projectSize; // чем больше, тем "дальше" будет казаться персонаж
	public Vector3 offset; // пишем в инспекторе (0,0,10)
	public Transform person; // сюда ссылку на персонажа, за к-м должна следить камера

	void Awake() {
		//MainCamera.orthographic = true;
	//	MainCamera.orthographicSize = projectSize;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = person.position + offset;
	}
}
