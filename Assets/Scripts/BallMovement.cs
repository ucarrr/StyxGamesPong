using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;



public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D ball;
    Vector2 sonHız;
    [SerializeField] TextMeshProUGUI player1Text, player2Text, winText, finishText, maxScoreText;
    private int player1Score, player2Score;
    [SerializeField] int maxScore;
    [SerializeField] AudioSource scoreSound, winSound, playerSound;
    MainMenu mainMenu;
    private void Start(){
        ball.velocity = new Vector2(-4,4);
    }
    void Update()
    {
        sonHız=ball.velocity;
        player1Text.text = player1Score.ToString();
        player2Text.text = player2Score.ToString();

        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D other){
        var newDirection = Vector2.Reflect(sonHız,other.contacts[0].normal);
        ball.velocity=newDirection;
        if (other.gameObject.tag == "Player1"){
            ball.velocity=ball.velocity*1.2f;
            playerSound.Play();
        }
        else if (other.gameObject.tag == "Player2"){
            playerSound.Play();
        }
        if (other.gameObject.tag == "Left Wall"){
             ball.velocity = new Vector2(-4,4);
            transform.position = new Vector2(0f, 0f);
            player1Score++;
            scoreSound.Play();
        }
        else if (other.gameObject.tag == "Right Wall"){
            ball.velocity = new Vector2(-4,4);
            transform.position = new Vector2(0f, 0f);
            player2Score++;
            scoreSound.Play();
        }
        if (player1Score == maxScore){
            winText.text = "Player1 Win Score : " + player1Score.ToString();
            finishText.text = "Press Enter to play again";
            winSound.Play();
            Time.timeScale = 0; 
        }
        else if (player2Score == maxScore){
            winText.text = "Player2 Win Score : " + player2Score.ToString();
            finishText.text = "Press Enter";
            winSound.Play();
            Time.timeScale = 0;
        }
    }
}