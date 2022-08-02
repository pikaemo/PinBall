using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    //���_��\������e�L�X�g
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        if (tag == "SmallStarTag")
        {
            this.scoreText.GetComponent<ScoreController>().score += 1;
        }
        else if (tag == "LargeStarTag")
        {
            this.scoreText.GetComponent<ScoreController>().score += 3;
        }
        else if (tag == "SmallCloudTag")
        {
            this.scoreText.GetComponent<ScoreController>().score += 5;
        }
        else if (tag == "LargeCloudTag")
        {
            this.scoreText.GetComponent<ScoreController>().score += 20;
        }
    }
}