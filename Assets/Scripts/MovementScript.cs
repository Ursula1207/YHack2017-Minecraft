using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	public float speed = 2f;
	public bool isRotating = true;
	public float turnSpeed = 4.0f;
	private float yaw = 0f;
	private float pitch = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
		}
		if (isRotating) {
			yaw += turnSpeed * Input.GetAxis ("Mouse X");
			pitch -= turnSpeed * Input.GetAxis ("Mouse Y");

			transform.eulerAngles = new Vector3 (pitch, yaw, 0.0f);
		}
	}
}
