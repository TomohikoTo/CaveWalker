using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DreamWalker {
public class KeyConfig : MonoBehaviour {
 

		//
		KeyData kd;
		public KeyCode[] codes;
		// ????????????
		public static Dictionary<int, KeyCode> Config
			= new Dictionary<int, KeyCode>();


		// ??????????
		public static bool GetKey(int key) {
			return Input.GetKey(Config[key]);
		}
		public static bool GetKeyDown(int key) {
			return Input.GetKeyDown(Config[key]);
		}
		public static bool GetKeyUp(int key) {
			return Input.GetKeyUp(Config[key]);
		}
		// ?????????
		void Start() {
		
			kd = GameObject.FindWithTag("KeyData").GetComponent<KeyData>();
		}
		

		void Update() {
			CheckKey();

		}

		void DefaultSetting(){
			kd.keyArray[0] = KeyCode.A;
			kd.keyArray[1] = KeyCode.W;
			kd.keyArray[2] = KeyCode.S;
			kd.keyArray[3] = KeyCode.E;
			kd.keyArray[4] = KeyCode.D;
			kd.keyArray[5] = KeyCode.R;
			kd.keyArray[6] = KeyCode.F;
			
			kd.keyArray[7] = KeyCode.LeftArrow;
			kd.keyArray[8] = KeyCode.UpArrow;
			kd.keyArray[9] = KeyCode.RightArrow;
			kd.keyArray[10] = KeyCode.DownArrow;
			kd.keyArray[11] = KeyCode.Return;

		}

		void CancelSetting(){
		}
		void SaveSetting(){
		}

		bool CheckKey(){
			int i ;
			//???????????
			for( i = 0 ; i < Config.Count ; i++){
				if( Input.GetKeyDown(kd.keyArray[i]) ){

					Debug.Log("キー入力が重複してます " );
					return false;
				}

			}

			return true;	
			
		}




}
}