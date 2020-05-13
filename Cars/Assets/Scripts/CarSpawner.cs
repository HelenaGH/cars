using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour 
{
	public GameObject[] Cars;
	int CarNo;
	public float maxPos = 2.45f;
	public float delayTimer = 1f;
	float timer;

	// Use this for initialization
	void Start () 
	{
		timer = delayTimer;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			Vector3 carPos = new Vector3(Random.Range(2.45f, -2.45f), transform.position.y, transform.position.z);
			CarNo = Random.Range(0, 5);
			Instantiate(Cars[CarNo], carPos, transform.rotation);
			timer = delayTimer;
		}
	}
}
