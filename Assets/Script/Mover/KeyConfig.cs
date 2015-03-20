using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DreamWalker {
public class KeyConfig : MonoBehaviour {
 
		public KeyCode[] codes;
		// キーコンフィグの設定情報
		public static Dictionary<int, KeyCode> Config
			= new Dictionary<int, KeyCode>();


		// キー状態取得メソッド
		public static bool GetKey(int key) {
			return Input.GetKey(Config[key]);
		}
		public static bool GetKeyDown(int key) {
			return Input.GetKeyDown(Config[key]);
		}
		public static bool GetKeyUp(int key) {
			return Input.GetKeyUp(Config[key]);
		}
		// キーコンフィグ設定
		void Start() {
			myNumbers[0] = KeyCode.A;
			KeyConfig.Config[0] = KeyCode.A;
			KeyConfig.Config[1] = KeyCode.W;
			KeyConfig.Config[2] = KeyCode.S;
			KeyConfig.Config[3] = KeyCode.E;
			KeyConfig.Config[4] = KeyCode.D;
			KeyConfig.Config[5] = KeyCode.R;
			KeyConfig.Config[6] = KeyCode.F;
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
			int i ;
			//キー入力取得用イベント
			for( i = 0 ; i < Config.Count ; i++){
				if( Input.GetKeyDown(KeyConfig.Config[i]) ){
					Debug.Log("入力キーが重複してます " );
				}

			}

				
			
		}




}
}