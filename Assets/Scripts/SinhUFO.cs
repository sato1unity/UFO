using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinhUFO : MonoBehaviour {
	public GameObject ga;
	public float x1,x2,y1,y2,tdx1,tdx2,tdy1,tdy2,ifl;
	public Text Score;
	public GameObject ga1;
	int i;
	void Start () {
		i = 0;
		float tdx = Random.Range (tdx1,tdx2);
		float tdy = Random.Range (tdy1,tdy2);
		InvokeRepeating ("sinh",tdx,tdy);
	}
	void Update () {
		if (i == ifl) {
			i = 0;
			Instantiate (ga1, new Vector3 (Random.Range (x1, x2), Random.Range (y1, y2), 0), Quaternion.identity);
		}
		i++;
	}
	void sinh()
	{
		
//		Instantiate (ga1, new Vector3 (Random.Range (-6f, 6f), Random.Range (4.9f, 5f), 0), Quaternion.identity);
	}
}
