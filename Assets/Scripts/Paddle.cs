using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public Ball ball;
    public float paddleXVelocity = 0f;

    private Rigidbody2D rbBall;
    private float mousePos;
    private float lastXPosition = 0f;

    void OnTriggerEnter2D(Collider2D trigger) {
        Debug.Log("triggered paddle");
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name.Equals("Ball")) {
            Vector2 ballVelocity = rbBall.velocity;
            ballVelocity.x = paddleXVelocity;
            rbBall.velocity = ballVelocity;
            print("set x veloicty as " + paddleXVelocity);
        }
       

    }

    // Use this for initialization
    void Start () {
        rbBall = ball.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f) ;
        this.transform.position = new Vector2(mousePos, 0.5f);

        float currentMouseX = Input.mousePosition.x;
        paddleXVelocity = currentMouseX - lastXPosition;
        lastXPosition = currentMouseX;
    }

    private void FixedUpdate() {
       
 
    }
}
