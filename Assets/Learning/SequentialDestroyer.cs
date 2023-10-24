using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SequentialDestroyer : MonoBehaviour
{
	[SerializeField]
	GameObject astreoidPrefab;
	GameObject spaceShip;
	List<GameObject> astreoidList = new List<GameObject>();
	GameObject targetAstreoid;
	void Start()
	{
		spaceShip = GameObject.FindGameObjectWithTag("spaceShip");
		astreoidList = new List<GameObject>();

	}


	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 position = Input.mousePosition;
			position.z = -Camera.main.transform.position.z;
			position = Camera.main.ScreenToWorldPoint(position);
			GameObject astreoid = Instantiate(astreoidPrefab, position, Quaternion.identity);
			astreoidList.Add(astreoid);
		}

		if (Input.GetMouseButtonDown(1))
		{
			DestroyTarget();
		}
	}

	GameObject CloseAstreoid()
	{
		GameObject closeAstreoid;
		float closeDistance;
		if (astreoidList.Count == 0)
		{
			return null;
		}
		else
		{
			closeAstreoid = astreoidList[0];
			closeDistance = DistanceMeter(closeAstreoid);
		}
		foreach (GameObject astreoid in astreoidList)
		{
			float distance = DistanceMeter(astreoid);
			if (distance < closeDistance)
			{
				closeDistance = distance;
				closeAstreoid = astreoid;
			}
		}

		return closeAstreoid;

	}

	public void DestroyTarget()
	{
		targetAstreoid = CloseAstreoid();
		if (targetAstreoid != null)
		{
			targetAstreoid.GetComponent<Destroy>().DestroyAstreoid(1);
			astreoidList.Remove(targetAstreoid);
		}


	}

	float DistanceMeter(GameObject target)
	{
		return Vector3.Distance(spaceShip.transform.position, target.transform.position);
	}
}
