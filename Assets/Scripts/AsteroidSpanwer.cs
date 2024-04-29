using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpanwer : MonoBehaviour {

    [SerializeField] private GameObject asteroidPrefab;

    private BoxCollider2D col;
    private List<Asteroid> asteroids = new List<Asteroid>();

    [SerializeField] private int maxNumAsteroids = 10;

    [SerializeField] private float maxMoveSpeed = 1000f;
    [SerializeField] private float minMoveSpeed = 100f;

    [SerializeField] private float maxTimeBetweenAsteroids = 2f;
    [SerializeField] private float minTimeBetweenAsteroids = 0.5f;
    private float lastSpawnTime;

    private void Awake() {
        for(int i = 0; i < maxNumAsteroids; i++) {
            GameObject asteroid = Instantiate(asteroidPrefab, this.transform);
            asteroids.Add(asteroid.GetComponent<Asteroid>());
            asteroid.SetActive(false);
        }

        lastSpawnTime = 0f;
    }

    private void Update() {
        if(Time.deltaTime >= lastSpawnTime + Random.Range(minTimeBetweenAsteroids, maxTimeBetweenAsteroids)) {
            Debug.Log("Spawn");
        }
    }

}
