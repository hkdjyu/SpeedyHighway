using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class BgScroll : MonoBehaviour {

    public float speed = -1.5f;
    Material _material;
    private void Awake() {
        _material = GetComponent<Renderer>().material;
    }

    void Start() {
    }

    void Update() {
        _material.mainTextureOffset += new Vector2(Time.deltaTime * speed, 0);
    }
}
