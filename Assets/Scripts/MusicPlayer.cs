using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer music;

    private void Awake() {
        Debug.Log(" Id is =" + this.GetInstanceID().ToString());
    }

    public void getInstance() {
        if(music != null) {
            Destroy(gameObject);
            Debug.Log("this");
        }else {
            music = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
       
    }
	// Use this for initialization
	void Start () {
        Debug.Log(" Id is =" + this.GetInstanceID().ToString());
        getInstance();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
