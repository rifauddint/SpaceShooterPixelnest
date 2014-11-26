using UnityEngine;
using System.Collections;

public class JalanScript : MonoBehaviour
{
		public float  SpeedX = 10f;
		public float SpeedY = 10f;
		private Vector2 movement;
		public Vector2 arah = new Vector2 (-1, 0);
	
		void Update ()
		{
				movement = new Vector2 (
			SpeedX * arah.x,
			SpeedY * arah.y);
		}
	
		void FixedUpdate ()
		{
				rigidbody2D.velocity = movement;
		}

}
