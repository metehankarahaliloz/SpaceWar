using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

	[SerializeField] GameObject spaceShipPrefab;

	[SerializeField] List<GameObject> astreoidPrefabs = new List<GameObject>();
	GameObject spaceShip;
	List<GameObject> astreoidList = new List<GameObject>();
	[SerializeField] int mode = 1;
	[SerializeField] int multiple = 5;
	UIControl uicontrol;
	void Start()
	{
		uicontrol = GetComponent<UIControl>();

	}
	public void GameStart()
	{
		uicontrol.GameStarted();
		spaceShip = Instantiate(spaceShipPrefab);
		spaceShip.transform.position = new Vector3(0, ScreenCalculate.Down + 1.5f);
		CreateAstreoid(5);
	}

	void Update()
	{

	}
	void CreateAstreoid(int piece)
	{
		Vector3 position = new Vector3();
		for (int i = 0; i < piece; i++)
		{
			position.z = -Camera.main.transform.position.z;
			position = Camera.main.ScreenToWorldPoint(position);
			position.x = Random.Range(ScreenCalculate.Left, ScreenCalculate.Right);
			position.y = ScreenCalculate.Top - 1;
			GameObject astreoid = Instantiate(astreoidPrefabs[Random.Range(0, 2)], position, Quaternion.identity);
			astreoidList.Add(astreoid);
		}
	}

	public void DestroyAstreoid(GameObject astreoid)
	{
		uicontrol.DestroyedAstreoid(astreoid);
		astreoidList.Remove(astreoid);
		if (astreoidList.Count <= mode)
		{
			mode++;
			CreateAstreoid(mode * multiple);
		}
	}

	public void GameOver()
	{
		foreach (GameObject astreoid in astreoidList)
		{
			astreoid.GetComponent<Astreoid>().DestroyAstreoid();

		}
		astreoidList.Clear();
		mode = 1;
		uicontrol.GameFinished();
	}
}
