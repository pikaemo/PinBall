using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject scoreText;

    //得点の初期値を0に設定
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //得点表示
        this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
    }
}
