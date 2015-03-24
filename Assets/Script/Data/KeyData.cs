using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DreamWalker {
public class KeyData : MonoBehaviour {


	//キーデータの配列
	public Dictionary<int, KeyCode> keyArray
		= new Dictionary<int, KeyCode>();
	KeyConfig kf;

	GameStateManager manager;
	public void GetKeyPoint(){

	}

	public void SetKeyPoint(){
	}

	// Use this for initialization
	void Start() {

		manager = GameObject.FindWithTag("GameManager").GetComponent<GameStateManager>();
		
		keyArray[0] = KeyCode.A;
		keyArray[1] = KeyCode.W;
		keyArray[2] = KeyCode.S;
		keyArray[3] = KeyCode.E;
		keyArray[4] = KeyCode.D;
		keyArray[5] = KeyCode.R;
		keyArray[6] = KeyCode.F;
		keyArray[7] = KeyCode.LeftArrow;
		keyArray[8] = KeyCode.UpArrow;
		keyArray[9] = KeyCode.RightArrow;
		keyArray[10] = KeyCode.DownArrow;
		keyArray[11] = KeyCode.Return;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
}
}
