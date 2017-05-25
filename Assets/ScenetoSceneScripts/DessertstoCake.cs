using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DessertstoCake : MonoBehaviour {
	
	//Change scene from Desserts to Cake
	public void MENU_ActionGotoPage(string sceneName)
	{
		Application.LoadLevel (2);
	}
}
