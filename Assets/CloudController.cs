﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {
	// 最小サイズ
	private float minimum = 1.0f;
	// 拡大縮小スピード
	private float magspeed = 1.0f;
	// 拡大率
	private float magnification = 0.07f;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.localScale = new Vector3 (this.minimum + Mathf.Sin (Time.time * this.magspeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin (Time.time * this.magspeed) * this.magnification);
		
	}
}