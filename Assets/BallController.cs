using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコアを表示するテキスト（追加）
    private GameObject ScoreText;
    //得点（追加）
    private int score = 0;



    // Use this for initialization
    void Start()

    {

        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のscoreTextオブジェクトを取得（追加）
        this.ScoreText = GameObject.Find("ScoreText");


    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            // スコアを加算(追加)
            this.score += 5;
            this.ScoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        }
        if (other.gameObject.tag == "LargeSterTag")
        {
            this.score += 10;
            this.ScoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        }
        if (other.gameObject.tag == "SmallCloudTag")
        {
            // スコアを加算(追加)
            this.score += 5;
            this.ScoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

        }
        if (other.gameObject.tag == "LargeCloudTag")
        {
            // スコアを加算(追加)
            this.score += 10;
            this.ScoreText.GetComponent<Text>().text = "Score " + this.score + "pt";
        }
    }
}