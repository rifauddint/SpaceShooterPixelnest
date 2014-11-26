using UnityEngine;
using System.Collections;

public class SampleCreate : MonoBehaviour
{

		public GameObject enemy;
		public float timerGenerateRate = 1	;
		float currentGenerateTime = 0;


	
		void Start ()
		{
//				for (int i = 0; i < 5; i++) {
//						GameObject clone = Instantiate (enemy) as GameObject;
//						//Destroy (clone, 1 + i / 2f);
//				}
		}
		// Update is called once per frame
		void Update ()
		{
				currentGenerateTime += Time.deltaTime;
				if (currentGenerateTime >= timerGenerateRate) {
						currentGenerateTime = 0;
					
						GenerateEnemy ();
					
				}
		}

		void GenerateEnemy ()
		{
				GameObject enemyClone = Instantiate (enemy) as GameObject;
				float posY = Random.Range (-9f, 9f);
				enemyClone.transform.position = new Vector3 (12, posY, 0);

		}
}
