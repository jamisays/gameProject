﻿using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        scoreText.text = (player.position.z+40).ToString("0");
	}
}
