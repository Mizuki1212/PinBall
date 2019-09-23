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
		// スコアをToString()メゾットの引数をD9で指定し、9桁で0埋めする
		ScoreText.GetComponent<Text> ().text = "Score: "  + score.ToString("D9");
			
	}

	 // 「OnCollisionEnter」BallのColliderが他のオブジェクトのColliderと衝突時に呼ばれる関数
	void OnCollisionEnter(Collision other){

		// 各タグに加算する点数を設定する
		if (other.gameObject.tag == "SmallStarTag") {
			score += 50;
		} else if (other.gameObject.tag == "SmallCloudTag") {
			score += 100;
		} else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag") {
			score += 500;
		} else if (max_score < score) {
			score = max_score;
		}

		// ScoreTextに衝突により加算された合計スコア変数を表示する
		// if文を使用してスコアが最大値に達した時に数値を振り切らないようにする
		// スコアをToString()メゾットの引数をD9で指定し、9桁で0埋めする
		ScoreText.GetComponent<Text> ().text = "Score: " + score.ToString("D9");
		if (score > max_score) {
			ScoreText.GetComponent<Text> ().text = "Score: " + max_score.ToString ("D9");
		}

	}
}


