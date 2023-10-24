using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
	float colliderHalfHeight;
	float colliderHalfWidth;

	void Start()
	{
		GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-5,5), Random.Range(-5, 5)), ForceMode2D.Impulse);
		BoxCollider2D collider2D = GetComponent<BoxCollider2D>();
		colliderHalfHeight = collider2D.size.y / 2;
		colliderHalfWidth = collider2D.size.x / 2;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//Debug.Log("Kemerleri Baðlayýn");

		//     if (collision.gameObject.tag == "")
		//     {
		//collision.gameObject.SendMessage("ApplyDamage", 10);
		//     }
	}

	void Update()
	{
		//Vector3 position = Input.mousePosition;
		//position.z = -Camera.main.transform.position.z;
		//position = Camera.main.ScreenToWorldPoint(position);
		//transform.position = position;
		//StayScreen();
	}

	void StayScreen()
	{
		Vector3 position = transform.position;
		if (position.x - colliderHalfWidth < ScreenCalculate.Left)
		{
			position.x = ScreenCalculate.Left + colliderHalfWidth;
		}
		else if (position.x + colliderHalfWidth > ScreenCalculate.Right)
		{
			position.x = ScreenCalculate.Right - colliderHalfWidth;
		}
		if (position.y + colliderHalfHeight > ScreenCalculate.Top)
		{
			position.y = ScreenCalculate.Top - colliderHalfHeight;
		}
		else if (position.y - colliderHalfHeight<ScreenCalculate.Down)
		{
			position.y = ScreenCalculate.Down + colliderHalfHeight;
		}
		transform.position = position;
	}
}
