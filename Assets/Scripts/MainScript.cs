using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour {

	public void PlayGameButton()
	{
		Application.LoadLevel ("1");
	}
	public void Quit()
	{
		Application.Quit ();
	}
}
