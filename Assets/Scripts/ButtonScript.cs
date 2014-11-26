using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{

		void OnMouseDown ()
		{
				switch (gameObject.name) {
				case "retry":
						Application.LoadLevel ("Level1");
						break;
				case "menu":
						Application.LoadLevel ("MainMenu");
						break;
				default:
						Application.LoadLevel ("Level1");
						break;

				}

				
		}
}
