using UnityEngine;
using System.Collections;

public class FPSDisplay : MonoBehaviour
{
	float deltaTime = 0.0f;
	public Font dafont;

	void Update()
	{
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}

	void OnGUI()
	{
		int w = Screen.width, h = Screen.height;

		GUIStyle style = new GUIStyle();

		Rect rect = new Rect(2, 4, w, h * 1f / 100);
		style.alignment = TextAnchor.UpperLeft;

		if (dafont != null){
			style.font = dafont;
		}

		style.fontSize = h * 2 / 100;
		style.normal.textColor = new Color (255f, 255f, 255f, 1f);
		float msec = deltaTime * 1000.0f;
		float fps = 1.0f / deltaTime;
		string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
		GUI.Label(rect, text, style);
	}
}