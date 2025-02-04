﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    public Text scoretext;
    private int score;
    private float scorevalue;
    public float totalcoins;
    public float timeleft;
    public int timeremaining;
    public Text timertext;
    private float TimerValue;
    public GameObject collisoneffect;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoretext.GetComponent<Text>().text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = "Score " + score;

        if (score>=60)
        {
            if (timeleft >= TimerValue)
            {
                SceneManager.LoadScene("winscene");
            }
        }
        else if (timeleft <= 0)
        {
            SceneManager.LoadScene("losescene");
        }
        timeleft -= Time.deltaTime;
        timeremaining = Mathf.FloorToInt(timeleft % 60);
        timertext.text = "Timer " + timeremaining.ToString();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            score += 10;
            Instantiate(collisoneffect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("water"))
        {
            SceneManager.LoadScene("losescene");
        }
    }
}

