using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //���_��\������e�L�X�g
    private GameObject scoreText;

    //���_�̏����l��0�ɐݒ�
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //���_�\��
        this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
    }
}
