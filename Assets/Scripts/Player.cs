using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    float vel;
    float screenHalfWidth;
    

    void Start()
    {
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidth = Camera.main.aspect*Camera.main.orthographicSize+halfPlayerWidth;
    }
    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");
        vel = input * speed;

        if (transform.position.x < -screenHalfWidth)
        {
            transform.position = new Vector2(screenHalfWidth, transform.position.y);
        }

        if (transform.position.x > screenHalfWidth)
        {
            transform.position = new Vector2(-screenHalfWidth, transform.position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * vel * Time.deltaTime);
    }
}
