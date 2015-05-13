//<summary>
//MainMenu Background
//Attached to Main Camera
//<summary>
using UnityEngine;
using System.Collections;

public class MainMenuBackground : MonoBehaviour {

	public Texture backgroundTexture;

	void OnGUI(){
		//Display our Background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
	}
}
