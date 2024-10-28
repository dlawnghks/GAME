using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class CountSys : MonoBehaviour
{
    private int count; // 시간을 정수로 설정
    private Text CountTx; // 화면에 출력할 텍스트
    public GameObject[] Stages;
    public int stageIndex;

    void Start()
    {
        count = 0;
        CountTx = GameObject.Find("Canvas").transform.Find("CountTx").GetComponent<Text>();
        StartCoroutine("CountRoutine");
    }

    IEnumerator CountRoutine()
    {
        while (true) // 무한루프
        {
            yield return new WaitForSeconds(0.1f);
            count += 1;
            CountTx.text = (count / 10).ToString() + "." + (count % 10).ToString();
        }
    }

    public void TimeCount()
    {
        int TimeC = count / 10; // CountTx에서 직접 값을 가져오지 않고 count 변수를 사용
        if (stageIndex == 0)
        {
            Debug.Log("타임카운트 정상 진입");
            if (TimeC < 20)
            {
                GameObject.Find("Canvas").transform.Find("APlus").gameObject.SetActive(true);
            }
            if (TimeC >= 20 && TimeC < 40)
            {
                GameObject.Find("Canvas").transform.Find("BPlus").gameObject.SetActive(true);
            }
            if (TimeC >= 40 && TimeC < 60)
            {
                GameObject.Find("Canvas").transform.Find("CPlus").gameObject.SetActive(true);
            }
            else if (TimeC >= 60)
            {
                GameObject.Find("Canvas").transform.Find("F").gameObject.SetActive(true);
            }
        }
        if (stageIndex == 1)
        {
            Debug.Log("타임카운트 정상 진입");
            if (TimeC < 20)
            {
                GameObject.Find("Canvas").transform.Find("APlus").gameObject.SetActive(true);
            }
            if (TimeC >= 20 && TimeC < 40)
            {
                GameObject.Find("Canvas").transform.Find("BPlus").gameObject.SetActive(true);
            }
            if (TimeC >= 40 && TimeC < 60)
            {
                GameObject.Find("Canvas").transform.Find("CPlus").gameObject.SetActive(true);
            }
            else if (TimeC >= 60)
            {
                GameObject.Find("Canvas").transform.Find("F").gameObject.SetActive(true);
            }
        }
        if (stageIndex == 2)
        {
            Debug.Log("타임카운트 정상 진입");
            if (TimeC < 20)
            {
                GameObject.Find("Canvas").transform.Find("APlus").gameObject.SetActive(true);
            }
            if (TimeC >= 20 && TimeC < 40)
            {
                GameObject.Find("Canvas").transform.Find("BPlus").gameObject.SetActive(true);
            }
            if (TimeC >= 40 && TimeC < 60)
            {
                GameObject.Find("Canvas").transform.Find("CPlus").gameObject.SetActive(true);
            }
            else if (TimeC >= 60)
            {
                GameObject.Find("Canvas").transform.Find("F").gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update에서 호출하지 않고, 필요할 때 TimeCount 메서드를 직접 호출하도록 하세요.
    }
}
