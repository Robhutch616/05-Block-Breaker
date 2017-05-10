using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loose : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D(Collider2D trigger) {
        Debug.Log("triggered");
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("collision with loose collider");
        if (levelManager != null) {
            levelManager.LoadLevel("Win Screen");
        }

    }

	// Use this for initialization
	void Start () {
        Debug.Log("beef");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
