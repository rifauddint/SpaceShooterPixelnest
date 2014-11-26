using UnityEngine;
using System.Collections;

public class ScrollingObject : MonoBehaviour
{

		public float speed;
		public int direction;
	
		void Update ()
		{

				for (int i = 0; i < transform.childCount; i++) {
						Transform child = transform.GetChild (i);

						float movement = speed * Time.deltaTime * direction;
						child.Translate (new Vector3 (movement, 0, 0));
			
						//Perulangan Background
						if (child.position.x <= -20) {
								child.position = new Vector3 (20, child.position.y, 
				                              child.position.z);
						}

				}

				
		
		}
}
