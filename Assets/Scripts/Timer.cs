using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public static float predictedTime;
	public Motor objectA;
	public Motor objectB;
	public TextMeshProUGUI predicted;
	public TextMeshProUGUI current;

	private void Start() {
		float h = objectA.gameObject.transform.position.x - objectB.transform.position.x;
		float a = objectB.acceleration - objectA.acceleration;
		float b = 2 * (objectB.initialVelocity - objectA.initialVelocity);
		float c = -2 * h;
		predictedTime = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
		print($"Predicted time: {predictedTime}");
		predicted.text = Timer.predictedTime.ToString();
	}

	private void FixedUpdate() {
		if (Time.fixedTime < Timer.predictedTime) {
			current.text = Time.fixedTime.ToString();
		}
	}
}
