using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
	[SerializeField]
	GameObject starPrefab;
	List<GameObject> stars = new List<GameObject>();


	/// <summary>
	/// show target stars
	/// </summary>
	public GameObject TargetStar
	{
		get
		{
			if (stars.Count > 0)
			{
				return stars[0];
			}
			else
			{
				return null;
			}

		}
	}



	void Update()
	{
        if (Input.GetMouseButtonDown(1))
        {
			Vector3 position = Input.mousePosition;
			position.z = -Camera.main.transform.position.z;
			Vector3 gameWorldPosition = Camera.main.ScreenToWorldPoint(position);
			stars.Add(Instantiate(starPrefab, gameWorldPosition, Quaternion.identity));
        }
    }
	/// <summary>
	/// Destroys the star sent as a parameter
	/// </summary>
	/// <param name="DestroyerStars"></param>

	public void DestroyStars(GameObject DestroyerStars)
	{
		stars.Remove(DestroyerStars);
		Destroy(DestroyerStars);
	}
}
