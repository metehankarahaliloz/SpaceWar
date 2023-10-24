using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

	[SerializeField]
	GameObject crashPrefab;
	Timer crashTimer;

	// Start is called before the first frame update
	void Start()
	{
		crashTimer = gameObject.AddComponent<Timer>();
		//crashTimer.TotalTime = Random.Range(1,20);
		//crashTimer.Work();


	}

	// Update is called once per frame
	void Update()
	{
		if (crashTimer.Finish)
		{
			Instantiate(crashPrefab, gameObject.transform.position, Quaternion.identity);
			Destroy(gameObject);

		}

	}

	public void DestroyAstreoid(int time)
	{
		crashTimer.TotalTime = time;
		crashTimer.Work();
	}
}
