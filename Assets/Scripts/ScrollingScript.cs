 using UnityEngine;
using System.Collections;

public class ScrollingScript : MonoBehaviour
{

		public float speed;
		public int direction;

		void Update ()
		{
				float movement = speed * Time.deltaTime * direction;
				transform.Translate (new Vector3 (movement, 0, 0));

				//Perulangan Background
				if (transform.position.x <= -20) {
						transform.position = new Vector3 (0, 0, transform.position.z);
				}


		}
}
