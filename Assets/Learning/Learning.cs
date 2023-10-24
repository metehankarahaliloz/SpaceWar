using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

        SpaceShip ship1 = new SpaceShip(Random.Range(80, 100));
        SpaceShip ship2 = new SpaceShip(Random.Range(80, 100));
        ship1.Speeder();
        ship2.Speeder();  
        ship1.Retarder();
        ship2.Retarder();





		//int crashAstroid = 20;
		//int playerHp = 100;

  //      if (crashAstroid == 20 && playerHp == 100)
  //      {
  //          Debug.Log("Mükemmle");
  //      }

        //switch (crashAstroid)
        //{
        //	case 1:
        //		Debug.Log("Good Start");
        //		break;
        //	case 10:
        //		Debug.Log("Good Job");
        //		break;
        //	default:
        //		Debug.Log("Loser");
        //		break;

        //}


    }

	// Update is called once per frame
	void Update()
	{

	}
}
