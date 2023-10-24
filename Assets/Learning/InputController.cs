using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
	[SerializeField]
	GameObject astreoidPrefab;

	List<GameObject> astreoidList = new List<GameObject>();

	//GameObject[] astreoids = new GameObject[4];
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			//Debug.Log(Input.mousePosition);
			Vector3 position = Input.mousePosition;
			position.z = -Camera.main.transform.position.z;
			position = Camera.main.ScreenToWorldPoint(position);

			for (int i = 0; i < 20; i++)
			{
				astreoidList.Add(Instantiate(astreoidPrefab, position, Quaternion.identity));
			}



		}
		//if (Input.GetMouseButton(0))
		//{
		//	Debug.Log("The left mouse button is being held down.");
		//}

		if (Input.GetMouseButtonDown(1))
		{
			
			foreach (GameObject astreoid in astreoidList)
			{
				Destroy(astreoid);
			}
			astreoidList.Clear();

			//for (int i = 0; i < astreoidList.Count; i++)
			//{
			//	Destroy(astreoidList[i]);

			//}
		}

		//if (Input.GetMouseButton(2))
		//{
		//	Debug.Log("The middle mouse button is being held down.");
		//}
	}
}
