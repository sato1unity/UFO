using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sounds2
{
	BACKGROUND = 0
};
public class SungBiDiet : MonoBehaviour {
	private AudioSource[] soundList;
	static private SungBiDiet instance = null;
	private GameObject mainCharacter = null;
	private SungBiDiet()
	{
		instance = this;
	}
	public static SungBiDiet GetInstance()
	{
		if (instance == null)
		{
			instance = new SungBiDiet(); 
			Debug.Log("Need create an instance");
		}
		return instance;
	}
	void Start () {
		soundList = GetComponents<AudioSource> ();
	}

	public void StartMusic(Sounds2 sid)
	{
		int id = (int)sid;
		Debug.Log ("Sound: " + id);
		if (id < soundList.Length) 
		{
			soundList[id].Play ();
		}
	}
}
