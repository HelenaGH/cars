using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float carSpeed;
	public float maxPos = 2.3f;
	Vector3 position;

	// Use this for initialization
	void Start () 
	{
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
		position.x = Mathf.Clamp(position.x, -2.4f, 2.4f);
		transform.position = position;

		position.y += Input.GetAxis("Vertical") * carSpeed * Time.deltaTime;
		position.y = Mathf.Clamp(position.x, -4f, 3.2f);
		transform.position = position;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "EnemyCar")
		{
			Destroy(gameObject);
		}
	}
}
