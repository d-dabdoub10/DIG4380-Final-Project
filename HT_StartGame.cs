﻿
// Daniel Dabdoub , DIG3480 Final Project 


using UnityEngine;
using System.Collections;

public class HT_StartGame : MonoBehaviour {

	public HT_GameController gameController;

	void OnMouseDown () {
		gameController.StartGame ();
	}
}