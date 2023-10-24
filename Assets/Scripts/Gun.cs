using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
	Timer timer;


	void Start()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
		timer = gameObject.AddComponent<Timer>();
		timer.TotalTime = 3;
		timer.Work();
	}

	// Update is called once per frame
	void Update()
	{

		if (timer.Finish)
		{
			Destroy(gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.gameObject.tag == "Astreoid")
        {
			Destroy(gameObject);

        }
    }
}
