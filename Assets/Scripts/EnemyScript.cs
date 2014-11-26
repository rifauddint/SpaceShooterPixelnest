using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

		public GameObject enemyShot;
		public GameObject enemyShot1;
		public GameObject enemyShot2;

		public int enemyTipe = 0;
		
		public float timerEnemyShootRate = 2;
		float currentTimerShoot;

		// Use this for initialization
		void Start ()
		{
	
		}	
		// Update is called once per frame
		void Update ()
		{
				currentTimerShoot += Time.deltaTime;
				if (currentTimerShoot >= timerEnemyShootRate) {
						currentTimerShoot = 0;
						if (renderer.isVisible) {
								GeneratePerulu ();
						}
				}
	
		}

		void GeneratePerulu ()
		{
				switch (enemyTipe) {
				case 0:
						GameObject shot0 = Instantiate (enemyShot) as GameObject;
						shot0.transform.position = transform.position;
						break;
				case 1:
						GameObject shot1 = Instantiate (enemyShot1) as GameObject;
						shot1.transform.position = transform.position;
						break;
				case 2:
						GameObject shot2 = Instantiate (enemyShot2) as GameObject;
						shot2.transform.position = transform.position;
						break;

				}
		}
}
