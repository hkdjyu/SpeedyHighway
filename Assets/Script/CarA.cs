using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarA : MonoBehaviour {

    public float speed = 8.0f;
    public Transform _pos;
    void Start() {
        _pos = GetComponent<Transform>();
    }

    void Update() {
        Vector2 deltaPos = new Vector2(speed * Time.deltaTime, 0);
        _pos.Translate(deltaPos);

        if (_pos.position.x > 11) {
            Destroy(this.gameObject);
        }

        Vector2 castPos = new Vector2(transform.position.x - 2.5f, transform.position.y);
        RaycastHit2D hit = Physics2D.Raycast(castPos, Vector2.left,1.0f);
        if (hit.collider != null) {
            Debug.Log("A" +hit.collider.name);
            speed += 0.1f;
        }
    }
}
