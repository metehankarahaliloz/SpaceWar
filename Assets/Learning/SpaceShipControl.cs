using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{
	const float power = 5;
	bool collect = false;
	GameObject target;
	Rigidbody2D myRigidbody2D;
	Picker picker;

	void Start()
	{
		myRigidbody2D = GetComponent<Rigidbody2D>();
		picker = Camera.main.GetComponent<Picker>();
	}

	void OnMouseDown()
	{
		if (!collect)
		{
			GoAndCollect();
		}
	}
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject == target)
		{
			picker.DestroyStars(target);
			myRigidbody2D.velocity = Vector2.zero;
			GoAndCollect();

		}
	}

	void GoAndCollect()
	{
		target = picker.TargetStar;
		if (target != null)
		{
			Vector2 targetLocation = new Vector2(target.transform.position.x
				- transform.position.x, target.transform.position.y - transform.position.y);
			targetLocation.Normalize();
			myRigidbody2D.AddForce(targetLocation * power, ForceMode2D.Impulse);
		}
	}


	void Update()
	{
		//Vector3 position = transform.position;
		//float horizontalInput = Input.GetAxis("Horizontal");
		//float verticalInput = Input.GetAxis("Vertical");

		//if (horizontalInput != 0)
		//{
		//	position.x += horizontalInput * power * Time.deltaTime;
		//}if (verticalInput != 0)
		//{
		//	position.y += verticalInput * power * Time.deltaTime;
		//}

		//transform.position = position;
	}
}
