using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform DestinationSpot;
	public Transform OriginSPot;
	public float Speed;
	public bool Switch = false;

	void FixedUpdate()
	{
		if (transform.position == DestinationSpot.position) 
		{
			Switch = true;
		}
		if (transform.position == OriginSPot.position) 
		{
			Switch = false;
		}
		if(Switch)
		{
			transform.position = Vector3.MoveTowards(transform.position, OriginSPot.position, Speed);

		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed);
			
		}
	}
}
