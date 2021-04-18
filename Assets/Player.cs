using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float playerScore;
    public GameObject gameOver;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = playerScore.ToString("00");
        MovePlayerTouch();

    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            playerScore += 1;
            print(playerScore);
        }
        if (collision.gameObject.tag == "Boom")
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }

    public void MovePlayerKeyBoard()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3((float)-0.05, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3((float)0.05, 0);
        }
    }

    public void MovePlayerTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                if (touch.position.x < 1164 / 2)
                {
                    transform.position += new Vector3((float)-0.05, 0);
                }
                else
                {
                    transform.position += new Vector3((float)0.05, 0);
                }

            }

            Debug.Log(touch.position.x);

        }
    }
}
