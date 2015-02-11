using UnityEngine;
using System.Collections;

public interface IState  {

	// Use this for initialization
	void Render ();
	
	
	// Update is called once per frame
	void StateUpdate ();
}
