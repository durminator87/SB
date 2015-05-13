using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {
	private bool PlayerInZone;
	public string levelToLoad;

	// Use this for initialization
	void Start () {
		PlayerInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerInZone) {
			Application.LoadLevel(levelToLoad);
		}
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player") {
			PlayerInZone=true;
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.name == "Player") {
			PlayerInZone=false;
		}
		
	}
}
