using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    public GameObject scoretext;
    private int score;
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
            SceneManager.LoadScene("winscene");
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            score += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag.Equals("water"))
        {
            SceneManager.LoadScene("losescene");
        }
    }
}

