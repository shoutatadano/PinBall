using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreTest : MonoBehaviour
{
    public Text scoreTest; //Text用変数
    private int score = 0; //スコア計算用変数
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "Cube")
        {
            score += 150;
        }
        else
        {
            score += 100;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreTest.text = string.Format("Score:{0}", score);
    }
   
       
    }