using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    private Rigidbody2D rbPaddle;

    private Rigidbody2D rb;
    private bool isReleased = false;
    private float mousePos;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rbPaddle = paddle.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isReleased) {
            mousePos = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, 0.5f, 15.5f);
            this.transform.position = new Vector2(mousePos, 1f);
        }
        if(Input.GetMouseButton(0) && !isReleased) {
            rb.velocity = new Vector2(paddle.paddleXVelocity, 10f);
            isReleased = true;
        }
	}

    void OnTriggerEnter2D(Collider2D trigger) {
        Debug.Log("triggered ball");
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("collision with ball collider");


    }
}
