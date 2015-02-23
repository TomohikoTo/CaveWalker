using UnityEngine;
using System.Collections;

namespace DreamWalker {
	public class MenuState : IState {
		private GameStateManager manager;
		
		public MenuState(GameStateManager GSManager) {
			//初期化
			manager = GSManager;
			Time.timeScale = 0;
		}
		//更新処理
		public void StateUpdate() {
			


		}
		
		public void Render() {
			//描画等
			
		}
		
	}
}