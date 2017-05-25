using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void MENU_ActionGotoPage(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}
}
