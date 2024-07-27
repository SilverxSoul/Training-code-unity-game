using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	public float MoveSpeed = 5.0f;

	public float frequency = 10.0f;  // Speed of sine movement
	public float magnitude = 0.5f;   // Size of sine movement
	private Vector3 axis;

	private Vector3 pos;

	void Start()
	{
		pos = transform.position;
		//Destroy(gameObject, 1.0f); tu huy sau 1 giay
		axis = transform.right;  // May or may not be the axis you want

	}

	void Update()
	{
		pos += transform.up * Time.deltaTime * MoveSpeed;
		transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
	}
}