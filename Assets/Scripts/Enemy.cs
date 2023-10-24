using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyFallingSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * enemyFallingSpeed * Time.deltaTime);
    }
}