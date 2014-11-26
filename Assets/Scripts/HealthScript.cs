using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour
{

		public int hp = 3;

		public bool isEnemy;

		public void Damage (int damageValue)
		{

				hp -= damageValue;
				if (hp <= 0) {

						SpecialEffectHelper.Instance.Explosion (transform.position);
						Destroy (gameObject);
						if (!isEnemy) {
								Application.LoadLevel ("GameOver");
						}

				}
		}

		/// <summary>
		/// Menabrak dengan sesuatu. Mengurangi point jika
		/// ketabrak oleh peluru 	
		/// </summary>
		/// <param name="col">Col.</param>
		void OnTriggerEnter2D (Collider2D col)
		{
				ShotScript shot = col.gameObject.GetComponent<ShotScript> ();
				if (shot != null) {
						if (shot.isEnemyShot != isEnemy) {
								Damage (shot.damage);
								Destroy (shot.gameObject);
						}

						
				}
		}


}
