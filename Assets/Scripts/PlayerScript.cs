using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{

		public float  SpeedX = 0.8f;
		public float SpeedY = 0.8f;
		
		public GameObject Shot;
		public GameObject Shot1;
		public GameObject Shot2;

		private Vector2 movement;
	
		void Update ()
		{
				float inputX = Input.GetAxis ("Horizontal");
				float inputY = Input.GetAxis ("Vertical");

				//
				if (Input.GetKey (KeyCode.Space)) {
						GameObject cloneShot = Instantiate (Shot) as GameObject;
						cloneShot.transform.position = gameObject.transform.position;
				}
				if (Input.GetButtonDown ("Fire1")) {
						GameObject cloneShot = Instantiate (Shot1) as GameObject;
						cloneShot.transform.position = gameObject.transform.position;
				}
				if (Input.GetKeyDown (KeyCode.B)) {
						GameObject cloneShot = Instantiate (Shot2) as GameObject;
						cloneShot.transform.position = gameObject.transform.position;
						cloneShot.transform.Translate (0, 1, 0);
				}




				movement = new Vector2 (
			SpeedX * inputX,
			SpeedY * inputY);
		
		}
	
		void FixedUpdate ()
		{
				rigidbody2D.velocity = movement;
		}


		void OnCollisionEnter2D (Collision2D col)
		{
				if (col.gameObject.name == "poulpi") {
						Destroy (gameObject);		
			
				}
				
				if (col.gameObject.name.Contains ("plat")) {
						Destroy (col.gameObject);

				}
		}
	
	
}
