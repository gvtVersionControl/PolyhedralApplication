using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour {

	public Texture Triangle;
	public Texture Square;
	public Texture Rectangle;
	public Texture Sphere;
	public Texture ıcoSphere;

	void OnGUI(){
						   //(l,t,w,h)
		GUI.Box (new Rect (0,0,70,600), "Shapes");

		GUI.Button (new Rect (10,30,40,40),Triangle);
		GUI.Button(new Rect (10,70,40,40), Square);
		GUI.Button (new Rect (10,110,40,40), Rectangle);
		GUI.Button (new Rect (10,150,40,40), ıcoSphere);
		GUI.Button (new Rect (10,190,40,40), Sphere);
	}
}
