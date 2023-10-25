using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector2 enemyFallingSpeed;
    float speed;
    float visibleHeightThreshold;

    private void Start()
    {
        speed = Mathf.Lerp(enemyFallingSpeed.y, enemyFallingSpeed.x, Difficulty.GetDifficultyPercent());
        visibleHeightThreshold=-Camera.main.orthographicSize-transform.localScale.y;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * enemyFallingSpeed * Time.deltaTime);
        if (transform.position.y < visibleHeightThreshold)
        {
            Destroy(gameObject);    
        }
    }
}
