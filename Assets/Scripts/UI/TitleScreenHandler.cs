﻿using UnityEngine;
using System.Collections;

public class TitleScreenHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Handheld.PlayFullScreenMovie("CarbonTitleSeq.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
