using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
	[SerializeField] GameObject gunPrefab = default;
	const float power = 5;
	[SerializeField] GameObject bomPrefab = default;
	GameControl gameControl;

	void Start()
	{
		gameControl = Camera.main.GetComponent<GameControl>();	
	}

	void Update()
	{
		Vector3 position = transform.position;
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		if (horizontalInput != 0)
		{
			position.x += horizontalInput * power * Time.deltaTime;
		}
		if (verticalInput != 0)
		{
			position.y += verticalInput * power * Time.deltaTime;
		}

		transform.position = position;

		if (Input.GetButtonDown("Jump"))
		{
			GameObject.FindGameObjectWithTag("Voice").GetComponent<VoiceControl>().Fire();
			Vector3 gunPosition = gameObject.transform.position;
			gunPosition.y += 1;
			Instantiate(gunPrefab, gunPosition, Quaternion.identity);
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Astreoid")
        {
			GameObject.FindGameObjectWithTag("Voice").GetComponent<VoiceControl>().ShipBurst();
			gameControl.GameOver();
			Instantiate(bomPrefab, gameObject.transform.position, Quaternion.identity);
			Destroy(gameObject);
        }
    }

}
