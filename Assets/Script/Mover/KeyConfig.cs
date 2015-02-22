﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DreamWalker {
public class KeyConfig : MonoBehaviour {

		Event keySet = Event.current;
		// キーコンフィグの設定情報
		public static Dictionary<string, KeyCode> Config
			= new Dictionary<string, KeyCode>();
		
		// キー状態取得メソッド
		public static bool GetKey(string key) {
			return Input.GetKey(Config[key]);
		}
		public static bool GetKeyDown(string key) {
			return Input.GetKeyDown(Config[key]);
		}
		public static bool GetKeyUp(string key) {
			return Input.GetKeyUp(Config[key]);
		}
		// キーコンフィグ設定
		void Start() {
			KeyConfig.Config["1"] = KeyCode.A;
			KeyConfig.Config["2"] = KeyCode.W;
			KeyConfig.Config["3"] = KeyCode.S;
			KeyConfig.Config["4"] = KeyCode.E;
			KeyConfig.Config["5"] = KeyCode.D;
			KeyConfig.Config["6"] = KeyCode.R;
			KeyConfig.Config["7"] = KeyCode.F;
		}
		
		// キーコンフィグ使用例
		void Update() {
			CheckKey();

		}

		void DefaultSetting(){
			KeyConfig.Config["1"] = KeyCode.A;
			KeyConfig.Config["2"] = KeyCode.W;
			KeyConfig.Config["3"] = KeyCode.S;
			KeyConfig.Config["4"] = KeyCode.E;
			KeyConfig.Config["5"] = KeyCode.D;
			KeyConfig.Config["6"] = KeyCode.R;
			KeyConfig.Config["7"] = KeyCode.F;
			
			KeyConfig.Config["Shoot"] = KeyCode.LeftArrow;
			KeyConfig.Config["Reloard"] = KeyCode.UpArrow;
			KeyConfig.Config["Guard"] = KeyCode.RightArrow;
			KeyConfig.Config["Charge"] = KeyCode.DownArrow;
			KeyConfig.Config["Pause"] = KeyCode.Return;

		}

		void CancelSetting(){
		}
		void SaveSetting(){
		}

		void CheckKey(){

			//キー入力取得用イベント


			if(keySet.isKey){
				//キーが重複してないか確認
				if( keySet.keyCode == KeyConfig.Config["1"]){

					Debug.Log("入力キーが重複してます " );
				
				}
				Debug.Log("入力キー" );
			}
			while(!Input.anyKeyDown){
			//	foreach(KeyCode code in ){
			//		if(Input.GetKeyDown (code)){
			//		}

			//	}
			}
		}
		IEnumerator CheckAllKeyDown ()
		{
			while (true) {
				while (!Input.anyKeyDown) yield return new WaitForSeconds (0.01F);
				
			//	foreach (KeyCode code in Enum.GetValues(typeof(KeyCode))) {
			//		if (Input.GetKeyDown (code)) { keyDown (code); break; }
			//	}
				
				yield return new WaitForSeconds (0.01F);
			}
		}



}
}