using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DreamWalker {
public class KeyConfig : MonoBehaviour {

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
			KeyConfig.Config["Left"] = KeyCode.LeftArrow;
			KeyConfig.Config["Right"] = KeyCode.RightArrow;
			KeyConfig.Config["Shoot"] = KeyCode.Z;
		}
		
		// キーコンフィグ使用例
		void Update() {
			// 自機の移動
			if ( KeyConfig.GetKeyDown("Left") ) {
				Debug.Log("Move Left");
			}
			if ( KeyConfig.GetKeyDown("Right") ) {
				Debug.Log("Move Right");
			}
			
			// 自機の停止
			if ( KeyConfig.GetKeyUp("Left") ) {
				Debug.Log("Stop Left");
			}
			if ( KeyConfig.GetKeyUp("Right") ) {
				Debug.Log("Stop Right");
			}
			
			// ショットの発射
			if ( KeyConfig.GetKey("Shoot") ) {
				Debug.Log("Shooting!");
			}
		}
}
}