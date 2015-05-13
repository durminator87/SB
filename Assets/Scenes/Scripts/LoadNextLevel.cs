using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
	public class LoadNextLevel : MonoBehaviour
	{
		public string NextLevelName;

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				Application.LoadLevel(NextLevelName);
			}
		}
	}
}
