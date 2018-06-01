﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform Playertarget; 

	public float smoothSpeed = 0.125f; 
	public Vector3 offset; 

	void LateUpdate ()
	{

		Vector3 desiredPosition = Playertarget.position + offset; 
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed); 
		transform.position = smoothedPosition; 

	}
}
