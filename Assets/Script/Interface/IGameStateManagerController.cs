using UnityEngine;
using System.Collections;

namespace DreamWalker{
public interface IGameStateManagerController {

		void GameStateManagerInit();
		string SwitchState(IState iState);
		string FormatState();
}
}