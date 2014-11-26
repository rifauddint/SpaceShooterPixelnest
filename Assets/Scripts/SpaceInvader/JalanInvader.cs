using UnityEngine;
using System.Collections;

public class JalanInvader : MonoBehaviour
{
		public float  SpeedX = 10f;
		public float translateY = 0.5f;
		private Vector2 movement;
		public Vector2 arah = new Vector2 (-1, 0);

		float counter = 3;
		public float COUNTER_SWITCH = 3;

		void Start ()
		{
				counter = COUNTER_SWITCH;

		}

		void Update ()
		{
				counter -= Time.deltaTime;
				if (counter <= 0) {
						SpeedX *= -1;
						gameObject.transform.Translate (new Vector3 (0, -translateY, 0));
						counter = COUNTER_SWITCH;
				}
				movement = new Vector2 (
			SpeedX * arah.x,
			0);
		}
	
		void FixedUpdate ()
		{
				rigidbody2D.velocity = movement;
		}

}
