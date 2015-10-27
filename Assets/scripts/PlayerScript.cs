using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float playerVelocity;
	public float boundary;
	private Vector3 playerPosition;
	private Vector3 interfaceposition;
	
	// используйте этот метод для инициализации
	void Start () {
		// получим начальную позицию платформы
		playerPosition = gameObject.transform.position;
		interfaceposition = gameObject.transform.position;
	}
	
	// Update вызывается при отрисовке каждого кадра игры
	void Update () {
		// горизонтальное движение
		playerPosition.x += Input.GetAxis ("Horizontal")*playerVelocity;
		interfaceposition.x += Input.GetAxis ("Horizontal") * playerVelocity;
		// выход из игры
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
		if(Input.anyKey) {
			animation.Play();}
		else animation.Stop();
		// обновим позицию платформы
		transform.position = playerPosition;
		if (playerPosition.x < -boundary) {

			transform.position = new Vector3 (-boundary, playerPosition.y, playerPosition.z);
		} 
		if (playerPosition.x > boundary) {
	//if(Input.anyKey){
		//	animation.Play();}
	//	else animation.Stop();
			transform.position = new Vector3(boundary, playerPosition.y, playerPosition.z);     
		}


	}
}