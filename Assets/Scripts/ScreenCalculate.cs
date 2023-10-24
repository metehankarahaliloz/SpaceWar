using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculate : MonoBehaviour
{
	static float left;
	static float right;
	static float top;
	static float down;

	/// <summary>
	/// Information giving the coordinates of the screen
	/// </summary>
	public static float Left
	{
		get
		{
			return left;
		}
	}
	public static float Right
	{
		get
		{
			return right;
		}
	}
	public static float Top
	{
		get
		{
			return top;
		}
	}
	public static float Down
	{
		get
		{
			return down;
		}
	}


	public static void Init()
	{
		float axisZ = -Camera.main.transform.position.z;
		Vector3 leftDownCorner = new Vector3(0, 0, axisZ);
		Vector3 rightUpCorner = new Vector3(Screen.width, Screen.height, axisZ);
		Vector3 LeftDownGameWorldCorner = Camera.main.ScreenToWorldPoint(leftDownCorner);
		Vector3 RightUpGameWorldCorner = Camera.main.ScreenToWorldPoint(rightUpCorner);
		left = LeftDownGameWorldCorner.x;
		right = RightUpGameWorldCorner.x;
		top = RightUpGameWorldCorner.y;
		down = LeftDownGameWorldCorner.y;
	}
}
