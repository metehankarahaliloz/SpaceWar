using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

	[SerializeField] GameObject gameNameText = default;
	[SerializeField] GameObject gameOverText = default;
	[SerializeField] Text pointText = default;
	[SerializeField] GameObject playButton = default;
	int point;

	void Start()
	{
		gameOverText.gameObject.SetActive(false);
		pointText.gameObject.SetActive(false);
	}

	public void GameStarted()
	{
		point = 0;
		gameNameText.gameObject.SetActive(false);
		playButton.gameObject.SetActive(false);
		pointText.gameObject.SetActive(true);
		gameOverText.gameObject.SetActive(false);
		UpdatePoint();
	}
	public void GameFinished()
	{
		gameOverText.gameObject.SetActive(true);
		playButton.gameObject.SetActive(true);
	}

	void UpdatePoint()
	{
		pointText.text = "PUAN: " + point;
	}

	public void DestroyedAstreoid(GameObject astreoid)
	{
		switch (astreoid.gameObject.name[8])
		{
			case '1':
				point += 5;
				UpdatePoint();
				break;
			case '2':
				point += 10;
				UpdatePoint();
				break;
			case '3':
				point += 15;
				UpdatePoint();
				break;
			default:
				break;
		}
	}
}
