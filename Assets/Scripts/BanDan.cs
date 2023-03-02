using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
	private static Singleton instance = null;
	private Singleton()
	{
		instance = this;
	}
	public static Singleton GetInstance()
	{
		if (instance == null)
		{
			instance = new Singleton ();
		}
		return instance;
	}
	public static void DestroyInstance()
	{
		instance = null;
	}
}
public enum Sounds
{
	BACKGROUND = 0,
	EFFECT = 1
};
public class BanDan : MonoBehaviour {
	private AudioSource[] soundList;
	static private BanDan instance = null;
	private GameObject mainCharacter = null;
	private BanDan()
	{
		instance = this;
	}
	public static BanDan GetInstance()
	{
		if (instance == null)
		{
			instance = new BanDan(); 
			Debug.Log("Need create an instance");
		}
		return instance;
	}
	void Start () {
		mainCharacter = GameObject.FindGameObjectWithTag("Player"); 
		if (mainCharacter != null)
		{
			Dan_Move script = mainCharacter.GetComponent<Dan_Move>();
			script.speed1 = new Vector3(1, 0, 0);
		}
		soundList = GetComponents<AudioSource> ();
	}

	public void StartMusic(Sounds sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}

}
