using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int stageIndex;
    public int health;
    public PlayerMove player;
    public GameObject[] Stages;
    public GameObject Menu_Image;
    public GameObject Restart;
    public Image[] UIHealth;
    public Text UIStage;
    public GameObject nextStage;
    public CountSys count;


    public void OnClickRestartButton()
    {
        Time.timeScale = 1.0f;
        if (stageIndex + 1 == 1)
            SceneManager.LoadScene("Stage1");
        if (stageIndex + 1 == 2)
            SceneManager.LoadScene("Stage2");
        if (stageIndex + 1 == 3)
            SceneManager.LoadScene("Stage3");
    }
    public void OnClickStartButton()
    {
        Menu_Image.SetActive(false);
        SceneManager.LoadScene("Stage1");
    }
    public void OnClicNextButton() //NextStage로 넘어가는 버튼을 활성화 시키는 함수
    {
        if (stageIndex + 1 == 1)
            SceneManager.LoadScene("Stage2");
        if (stageIndex + 1 == 2)
            SceneManager.LoadScene("Stage3");
        if (stageIndex + 1 == 3)
            SceneManager.LoadScene("Stage4");
        stageIndex++;
        Time.timeScale = 1.0f;
    }

    public void OnMainMenuButton() //MainMenu로 넘어가는 버튼
    {
        SceneManager.LoadScene("scene1");
    }
    public void NextStage()
    {
        //change stage
        if (stageIndex < Stages.Length)
        {

            Debug.Log("Stage Clear!");




            GameObject.Find("Canvas").transform.Find("GameClear").gameObject.SetActive(true);
            //캔버스의 자식객체인 게임클리어 부분을 표시되게 변경함
            count.TimeCount();



            //Stages[stageIndex].SetActive(true);
            //if (stageIndex == 1)
            //    SceneManager.LoadScene("Stage2");
            //if (stageIndex == 2)
            //    SceneManager.LoadScene("Stage3");
            PlayerReposition();
        }
        else //���� Ŭ����
        {
            //�ð� ����
            Time.timeScale = 0;
            //result ui
            Debug.Log("� �Ϸ�");
        }

    }


    // Update is called once per frame
    void Update()
    {

    }

    public void HealthDown()
    {
        if (health > 0)
        {
            health--;
            UIHealth[health].enabled = false;
        }
        else
        {
            //player die effect
            player.OnDie();
            GameObject.Find("Canvas").transform.Find("Failed").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("F").gameObject.SetActive(true);
            //result ui
            Debug.Log("� ����");

            //retry button ui

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Player Reposition
            if (health > 0)
            {
                PlayerReposition();
            }
            //Health Down
            HealthDown();
        }
    }
    void PlayerReposition()
    {
        player.transform.position = new Vector3(-3, -5, -1);
        player.VelocityZero();
    }
}
