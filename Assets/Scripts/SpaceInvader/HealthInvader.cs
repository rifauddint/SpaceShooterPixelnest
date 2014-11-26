using UnityEngine;
using System.Collections;

public class HealthInvader : MonoBehaviour
{

		public int hp = 3;

		public bool isEnemy;

		public void Damage (int damageValue)
		{
				hp -= damageValue;
				if (hp <= 0)
						Destroy (gameObject);
		}

		/// <summary>
		/// Menabrak dengan sesuatu. Mengurangi point jika
		/// ketabrak oleh peluru 	
		/// </summary>
		/// <param name="col">Col.</param>
		void OnTriggerEnter2D (Collider2D col)
		{
				ShotInvader shot = col.gameObject.GetComponent<ShotInvader> ();
				if (shot != null) {
						if (shot.isEnemyShot != isEnemy) {
								Damage (shot.damage);
								Destroy (shot.gameObject);
						}

						
				}
		}


}
