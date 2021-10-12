using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscript : MonoBehaviour
{
    public GameObject scoretext;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 10;
        scoretext.GetComponent<Text>().text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.GetComponent<Text>().text = "Score " + score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("coin"))
        {
            score += 10;
            Destroy(collision.gameObject);
        }
    }
}

