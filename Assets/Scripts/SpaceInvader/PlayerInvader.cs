using UnityEngine;
using System.Collections;

public class PlayerInvader : MonoBehaviour
{

		public float  SpeedX = 0.8f;
		public float SpeedY = 0.8f;
		
		public GameObject Shot;
		GameObject cloneShot;

		private Vector2 movement;
	
		void Update ()
		{
				float inputX = Input.GetAxis ("Horizontal");
				//	float inputY = Input.GetAxis ("Vertical");
				float inputY = 0;

				//
				if (Input.GetKeyDown (KeyCode.Space) && cloneShot == null) {
						cloneShot = Instantiate (Shot) as GameObject;
						cloneShot.transform.position = gameObject.transform.position;
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
