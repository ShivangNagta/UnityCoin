using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    Vector2 halfCamera;
    float nextSpawnTime;
    public Vector2 spawnInterval;
    public Vector2 spawnSizeInterval;
    public float maxAngle;

    // Start is called before the first frame update
    void Start()
    {
        halfCamera = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float secondsBetweenSpawn =Mathf.Lerp(spawnInterval.y,spawnInterval.x,Difficulty.GetDifficultyPercent());
            float newAngle = Random.Range(-maxAngle, maxAngle);
            float spawnSize = Random.Range(spawnSizeInterval.x, spawnSizeInterval.y);
            nextSpawnTime = Time.time+secondsBetweenSpawn;
            Vector2 spawnPosition = new Vector2 ((Random.Range(-halfCamera.x, halfCamera.x)), halfCamera.y+spawnSize/2f);
            GameObject newEnemy = (GameObject)Instantiate (Enemy, spawnPosition, Quaternion.Euler(Vector3.forward*newAngle));
            newEnemy.transform.localScale = Vector3.one * spawnSize;
        }
    }
}
