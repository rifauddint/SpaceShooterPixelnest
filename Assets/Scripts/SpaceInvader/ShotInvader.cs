using UnityEngine;
using System.Collections;

public class ShotInvader : MonoBehaviour
{

		public int damage = 1;
		public bool isEnemyShot = false;
		public int tipe = 0;

		public GameObject Shot1;
		
		public float timerMove = 1	;
		float currentTimer = 0;
		bool isUp = false;

	
		void Update ()
		{
				if (tipe == 1) {
						currentTimer += Time.deltaTime;
						if (currentTimer >= timerMove) {
								currentTimer = 0;
								isUp = !isUp;
						}
				}

				if (!gameObject.renderer.isVisible) {
						Destroy (gameObject);
				}
		}

		void FixedUpdate ()
		{	
				if (tipe == 1) {
						if (isUp) {
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 10f);
						} else {
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, -10f);

						}
				}
		}




	
		void Start ()
		{
				if (tipe == 2) {
						GameObject clone = Instantiate (Shot1) as GameObject;
						clone.transform.position = transform.position;
						clone.GetComponent<ShotInvader> ().tipe = 1;
						clone.GetComponent<ShotInvader> ().isUp = true;

						GameObject clone2 = Instantiate (Shot1) as GameObject;
						clone2 .transform.position = transform.position;
						clone2.GetComponent<ShotInvader> ().tipe = 1;
						clone2.GetComponent<ShotInvader> ().isUp = false;
				}
		
				Destroy (gameObject, 7);
		
		}



}
