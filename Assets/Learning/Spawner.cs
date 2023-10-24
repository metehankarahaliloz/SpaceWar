using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] GameObject astreoidPrefab;
	Timer timer;
	void Start()
	{
		timer = gameObject.AddComponent<Timer>();
		timer.TotalTime = 1;
		timer.Work(); ;
	}

	// Update is called once per frame
	void Update()
	{
		if (timer.Finish)
		{
			SpawnAstreoid();

			timer.Work();

		}
	}

	void SpawnAstreoid()
	{
		Instantiate(astreoidPrefab);
	}
}
