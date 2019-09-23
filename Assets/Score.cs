using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour {


	// 課題 UIのテキストを使って得点を表示してください------------------------------------

	// スコアテキストを表示するテキスト
	private GameObject ScoreText;

	// スコアを0で初期化
	int score= 0;

	// スコアの最大値を999999999に設定
	const int max_score = 999999999;

	// Use this for initialization
	void Start () {

		// シーン中にScoreTextオブジェクトを取得
		ScoreText = GameObject.Find("ScoreText");

		// ScoreTextに0で初期化したスコア変数を表示する
		ScoreText.GetComponent<Text> ().text = "Score: " + score;
			
	}

	 // 「OnCollisionEnter」BallのColliderが他のオブジェクトのColliderと衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other){

		// 各タグに加算する点数を設定する
		if (other.gameObject.tag == "SmallStarTag") {
			score += 10;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			score += 50;
		} else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag") {
			score += 100;
		} else if (max_score < score) {
			score = max_score;
		}

		// ScoreTextに衝突により加算された合計スコア変数を表示する
		ScoreText.GetComponent<Text> ().text = "Score: " + score;


	}
}


