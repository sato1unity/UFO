using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sung_Move : MonoBehaviour {
	public float diem;
	[SerializeField]
	public Text Score;
	public float speed1;
	public Vector3 speed2;
	public GameObject dan;
	int i;
	void Start () {
		diem = 0;
		speed2 = new Vector3 (3, 0, 0);
		Score.text = "SCORES: " + diem.ToString ();
	}
	void Update () {
		if ((Input.GetKey (KeyCode.LeftArrow) && transform.position.x>-42.7f)||(Input.GetKey (KeyCode.S) && transform.position.x>-42.7f)) {
			transform.Translate (Vector3.left * speed1 * Time.deltaTime);
		}
		if ((Input.GetKey (KeyCode.RightArrow) && transform.position.x<296.6f)||(Input.GetKey (KeyCode.F) && transform.position.x<296.6f)) {
			transform.Translate (Vector3.right * speed1 * Time.deltaTime);
		}
		if ((Input.GetKey (KeyCode.UpArrow) && transform.position.y<29.2f)||(Input.GetKey (KeyCode.E) && transform.position.y<29.20f)) {
			transform.Translate (Vector3.up * speed1 * Time.deltaTime);
		}
		if ((Input.GetKey (KeyCode.DownArrow) && transform.position.y>-194.5f)||(Input.GetKey (KeyCode.D) && transform.position.y>-194.5f)) {
			transform.Translate (Vector3.down * speed1 * Time.deltaTime);
		}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{		
		
	}
	void OnTriggerEnter2D(Collider2D tager){
		if (tager.tag == "Ga") {			
			SungBiDiet.GetInstance().StartMusic(Sounds2.BACKGROUND);
			Destroy (tager.gameObject);
			Application.LoadLevel("gameover");
		}
		if (tager.tag == "BTC") {
			diem++;
			Score.text = "SCORES: " + diem.ToString ();
			Destroy (tager.gameObject);
			AnCoin.GetInstance().StartMusic(Sounds3.BACKGROUND);
		}
		if (tager.tag == "ETH") {
			diem += 0.5f;
			Score.text = "SCORES: " + diem.ToString ();
			Destroy (tager.gameObject);
			AnCoin.GetInstance().StartMusic(Sounds3.BACKGROUND);
		}
	}
}
