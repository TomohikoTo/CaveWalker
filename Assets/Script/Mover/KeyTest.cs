using UnityEngine;
using System.Collections;

public class KeyTest : MonoBehaviour {

	void OnGUI() {
		Event e = Event.current;
		if (e.isKey)
			Debug.Log("Detected key code: " + e.keyCode);
		
	}
}
