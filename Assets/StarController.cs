using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

	// 回転速度
	private float rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		// 回転を開始する角度を設定(宿題）
		// 答え：Y軸回転のStarが回転を開始した際に、初期角度がランダムな位置で回転を開始する。回転角度（最小0°～最大360°）
		this.transform.Rotate (0, Random.Range (0, 360), 0);

		
	}
	
	// Update is called once per frame
	void Update () {
		// 回転
		this.transform.Rotate (0, this.rotSpeed, 0);
		
	}
}
