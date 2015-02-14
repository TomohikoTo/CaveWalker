using UnityEngine;
using System.Collections;

namespace DreamWalker {
	public class ResultState : IState {
		private GameStateManager manager;
		
		public ResultState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			Time.timeScale = 0;
		}
		
		public void StateUpdate() {
			
			//更新処理
			if(Input.anyKey) { // 何らかのキーを押すとMenuStateに遷移
				
				
				//	manager.SwitchState(new MenuState(manager));
				//Application.LoadLevel("Menu");
			}
		}
		
		public void Render() {
			//描画等
			
		}
		
	}
}