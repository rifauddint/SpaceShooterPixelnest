using UnityEngine;
using System.Collections;

using UnityEngine;


public class MoveScript : MonoBehaviour
{
		public Vector2 speed = new Vector2 (10, 10);
		public Vector2 direction = new Vector2 (-1, 0);
		private Vector2 movement;

	
		void Update ()
		{
			
				movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);
		}
	
		void FixedUpdate ()
		{
				// Apply movement to the rigidbody
				rigidbody2D.velocity = movement;
		}
}
