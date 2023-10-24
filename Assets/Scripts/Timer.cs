using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update




    float totalTime = 0;
    float actionTime = 0;
    bool work = false;
    bool start = false;
	/// <summary>
	/// Sets the total duration of the countdown timer
	/// </summary>
	public float TotalTime
    {
        set
        {
            if (!work)
            {
                totalTime = value;
            }
        }
    }
	/// <summary>
	/// Tells if the countdown is over
	/// </summary>
	public bool Finish
    {
        get
        {
            return start && !work;
        }
    }
	/// <summary>
	/// Runs the counter
	/// </summary>
	public void Work( )
	{
        if (totalTime >0)
        {
            work = true;
            start = true;
            actionTime = 0;
        }
    }


    
    void Update()
    {
        if (work)
        {
            actionTime += Time.deltaTime;
            if (actionTime >= totalTime)
            {
                work = false;
            }
        }
    }
}
