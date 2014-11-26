using UnityEngine;
using System.Collections;

public class ProffesorScript : MonoBehaviour
{
		Animator aniProffesor;
		public GameObject Shot;
		// Use this for initialization
		void Start ()
		{

				aniProffesor = GetComponent<Animator> ();
				

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetAxis ("Horizontal") > 0) {
						aniProffesor.SetInteger ("Direction", 1);
						rigidbody2D.velocity = new Vector2 (10f, rigidbody2D.velocity.y);


				} else if (Input.GetAxis ("Horizontal") < 0) {
						aniProffesor.SetInteger ("Direction", -1);
						rigidbody2D.velocity = new Vector2 (-10f, rigidbody2D.velocity.y);
				} else {
						rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
						aniProffesor.SetInteger ("Direction", 0);

				}
				if (Input.GetButtonDown ("Fire1")) {
						GameObject cloneShot = Instantiate (Shot) as GameObject;
						cloneShot.transform.position = gameObject.transform.position;
						cloneShot.transform.Translate (0, 1, 0);
				}
			
				
				if (Input.GetKeyUp (KeyCode.Space)) {
						if (rigidbody2D.velocity.y == 0) {
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0.1f);
								rigidbody2D.AddForce (new Vector2 (0, 1000));
						}
//						rigidbody2D.velocity = new Vector2 (10f, 0);
						
			
			
				}
		}
}
