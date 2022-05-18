using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    public GameControl GameControl;
    
    public float speed;
    private Transform _pos;
    public float maxY, minY;
    private float moveY;
    public AudioClip sfx;
    
    void Start() {
        sfx = GetComponent<AudioSource>().clip;
        GetComponent<AudioSource>().playOnAwake = false;
        _pos = GetComponent<Transform>();
        speed = 5.0f;
        maxY = 2.5f;
        minY = -maxY;
    }

    void Update() {

        if (Input.GetKey(KeyCode.DownArrow) && _pos.position.y >= minY)
                _pos.Translate(0,-speed*Time.deltaTime,0);
        if (Input.GetKey(KeyCode.UpArrow) && _pos.position.y <= maxY)
                _pos.Translate(0,speed*Time.deltaTime,0);
    }

    void OnCollisionEnter2D (Collision2D other) {
        GameControl.GameOver();
        GetComponent<AudioSource>().Play();
    }
    
    
}
