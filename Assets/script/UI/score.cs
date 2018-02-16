using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ★追加
using UnityEngine.UI;

public class score : MonoBehaviour {

    // ★追加
    private int  Score = 0;
    private Text scoreLabel;


    // Use this for initialization
    void Start () {
        // ★追加
        // 「Text」コンポーネントにアクセスして取得する（ポイント）
        scoreLabel = this.gameObject.GetComponent<Text>();
        scoreLabel.text = "score " + Score;

    }
    // ★追加
    // スコアを加算するメソッド（命令ブロック）
    // 「public」をつけて外部からこのメソッドにアクセスできるようにする（重要ポイント）
    public void AddScore(int amount)
    {

        // 「amount」に入ってくる数値分を加算していく。
        Score += amount;

        scoreLabel.text = "Score " + Score;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
