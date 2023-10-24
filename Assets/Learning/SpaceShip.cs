using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip
{
	/// <summary>
	/// Maximum speed limit of the ship
	/// </summary>
	int maxSpeed;

	/// <summary>
	/// Ship Color
	/// </summary>
	string color;

	/// <summary>
	/// Return has ship's max speed 
	/// </summary>
	public int MaximumSpeed
	{
		get
		{
			return maxSpeed;
		}
	}
	/// <summary>
	/// Return has ship's Color 
	/// </summary>
	public string Color
	{
		get
		{
			return color;
		}
	}
	/// <summary>
	/// Define maximum speed and color of ship
	/// </summary>
	/// <param name="maxSpeed"></param>
	/// <param name="color"></param>

	public SpaceShip(int maxSpeed, string color = "Red")
	{
		this.maxSpeed = maxSpeed;
		this.color = color;

	}
	public SpaceShip(int maxSpeed)
	{
		this.maxSpeed = maxSpeed;
	}


	/// <summary>
	/// spaceship acceleration superpower
	/// </summary>
	public void Speeder()
	{
		maxSpeed += Random.Range(5, 20);
		Debug.Log(maxSpeed);
	}
	/// <summary>
	/// spaceship slower
	/// </summary>
	public void Retarder()
	{
		maxSpeed -= Random.Range(5, 20);
		Debug.Log(maxSpeed);

	}


}
