using UnityEngine;
using System.Collections;

namespace DreamWalker {
	public class MenuState : IState {
		private GameStateManager manager;

		GameObject MenuObj;	//メニューアイコン取得用オブジェクト
		public MenuState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			Time.timeScale = 0;
		}
		//更新処理
		public void StateUpdate() {
			GetMenuObject();

		}
		
		public void Render() {
			//描画等
			
		}

		//メニューオブジェクトの取得
		void GetMenuObject(){
			if( Input.GetMouseButtonDown(0)){
				Ray ray;
				RaycastHit hit = new RaycastHit() ;
				ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit , 500)) {
					//selectedGameObject = hit.collider.gameObject;
					MenuObj = hit.collider.gameObject;
					SwitchMenuState();
					
				} else {
					//
				}
			}

		}

		//クリックいたメニューのオブジェクトに応じてstateの切り替えを行う処理
		void SwitchMenuState()
		{
			//ステージ選択stateに切り替え
			if(
				MenuObj.name == "STAGE SELECT")
			{
				manager.SwitchState(new StageSelectState(manager));  
			}
			//メメント関連のstateに切り替え
			else if(MenuObj.name == "MEMORY")
			{
				//Memento画面の加算読み込み
				Application.LoadLevel("Memento");
				manager.SwitchState(new MemoryState(manager));
				Debug.Log("MEMENTO");
			}
			//オプション関連のstateに切り替え
			else if(MenuObj.name == "OPTION")
			{
				//Option画面の加算読み込み
				Application.LoadLevelAdditive("Option");
				manager.SwitchState(new OptionState(manager));
				Debug.Log("OPTION");
			}
			//クレジット関連のstateに切り替え
			else if(MenuObj.name == "RANKING")
			{
				//クレジット画面の加算読み込み
				Application.LoadLevel("Ranking");
				manager.SwitchState(new RankingState(manager));
				Debug.Log("CREDIT");
			}
		}
	}
}