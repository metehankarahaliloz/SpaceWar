using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountBackTime : MonoBehaviour
{
	Timer timer;
	float startTime;
	void Start()
	{
		timer = gameObject.AddComponent<Timer>();
		timer.TotalTime = 3;
		timer.Work();
		startTime = Time.time;
	}


	void Update()
	{
		if (timer.Finish)
		{
			float countTime = Time.time - startTime;
			Debug.Log(countTime);
			startTime = Time.time;
			timer.Work();


		}
	}
}
