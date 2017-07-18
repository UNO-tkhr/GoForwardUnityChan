using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CubeController : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed, 0, 0);

		//画面外に出たら破棄する
		if(transform.position.x < this.deadLine){
			Destroy(gameObject);
		}
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "ground" || col.gameObject.tag == "cube"){
			AudioSource audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.Play();
		}
	}
}
