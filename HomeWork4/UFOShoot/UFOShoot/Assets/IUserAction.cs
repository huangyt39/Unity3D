﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoundState {EASY, NORMAL, HARD}

public interface IUserAction{

	void ReStart ();
	void Begin ();
	void GameOver ();
	void DisplayScore ();
	void ChoseRound ();
	void PAUSE ();
	void GoOn ();
	int getScore ();
}
