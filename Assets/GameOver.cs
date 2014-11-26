using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour
{

	
		void OnGUI ()
		{
				const int buttonWidth = 100;
				const int buttonHeight = 80;
		
				Rect buttonRect = new Rect (
			Screen.width / 2 - (buttonWidth / 2) - buttonWidth,
			Screen.width * 2 / 3 - (buttonHeight / 2),
			
			buttonWidth,
			buttonHeight
				);
		
				if (GUI.Button (buttonRect, "Restart")) {
						Application.LoadLevel ("Level1");
				}

				Rect buttonRect2 = new Rect (
			Screen.width / 2 - (buttonWidth / 2) + buttonWidth,
		
			Screen.width * 2 / 3 - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
				);


				if (GUI.Button (buttonRect2, "Menu")) {
						Application.LoadLevel ("MainMenu");

				}

		
		}

}
