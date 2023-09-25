using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Motor : MonoBehaviour
{
	public float initialVelocity;
	public float acceleration;
	float currentVelocity;


	private void Start() {
		currentVelocity = initialVelocity;
	}

	private void FixedUpdate() {
		if (Time.fixedTime < Timer.predictedTime) {
			currentVelocity += acceleration * Time.fixedDeltaTime;
			transform.Translate(Vector3.right * currentVelocity * Time.fixedDeltaTime);
		}
	}
}
