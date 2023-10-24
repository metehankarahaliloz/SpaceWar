using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Astreoid : MonoBehaviour
{
	[SerializeField] GameObject bomPrefab = default;
	GameControl gameControl;

	void Start()
	{
		Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
		gameControl = Camera.main.GetComponent<GameControl>();

		float direction = Random.Range(0.0f, 1.0f);
		if (direction < 0.5)
		{
			rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
			rb2d.AddTorque(direction*10.0f);	
		}
		else
		{
			rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
			rb2d.AddTorque(-direction * 2.0f);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "gun")
		{
			GameObject.FindGameObjectWithTag("Voice").GetComponent<VoiceControl>().AstreoidBurst();
			gameControl.DestroyAstreoid(gameObject);
			DestroyAstreoid();
		}
	}
	public void DestroyAstreoid()
	{
		Instantiate(bomPrefab, gameObject.transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
