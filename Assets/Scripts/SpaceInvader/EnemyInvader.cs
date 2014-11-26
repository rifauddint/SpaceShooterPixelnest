using UnityEngine;
using System.Collections;

public class EnemyInvader : MonoBehaviour
{

		public GameObject enemyShot;

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

		void OnCollisionEnter2D (Collision2D cd)
		{
				if (cd.gameObject.name == "player") {
						Destroy (cd.gameObject);

				}
			
		}

		void GeneratePerulu ()
		{
				int randValue = Random.Range (0, 40);
				GameObject shot0;
				switch (enemyTipe) {
				case 0:
						
						
						break;
				case 1:
						if (randValue < 2) {
								shot0 = Instantiate (enemyShot) as GameObject;
								shot0.transform.position = transform.position;
						}
						break;
				case 2:
						if (randValue < 4) {
								shot0 = Instantiate (enemyShot) as GameObject;
								shot0.transform.position = transform.position;			
						}
						break;

				}
		}
}
