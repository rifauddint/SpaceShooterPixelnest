using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
		GUISkin skin;
		void Start ()
		{
				skin = Resources.Load ("TemplateBaru") as GUISkin;

		}

		void OnGUI ()
		{
				const int buttonWidth = 100;
				const int buttonHeight = 80;

				GUI.skin = skin;

				Rect buttonRect = new Rect (
					Screen.width / 2 - (buttonWidth / 2),
					Screen.width * 2 / 3 - (buttonHeight / 2),
					buttonWidth,
					buttonHeight
				);

				if (GUI.Button (buttonRect, "Start")) {
						Application.LoadLevel ("Level1");
				}

		}

}
