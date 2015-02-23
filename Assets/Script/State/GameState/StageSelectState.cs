using UnityEngine;
using System.Collections;

namespace DreamWalker {
	public class StageSelectState : IState {
		private GameStateManager manager;
		
		public StageSelectState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			Time.timeScale = 0;
		}
		//更新処理
		public void StateUpdate() {
			// 何らかのキーを押すとMenuStateに遷移
			if(Input.anyKey) { 
				
				manager.SwitchState(new MenuState(manager));
				Application.LoadLevel("Menu");
			}
		}
		
		public void Render() {
			//描画等
			
		}
		
	}
}
