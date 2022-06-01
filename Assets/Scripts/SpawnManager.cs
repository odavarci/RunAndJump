using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstacle;
    Vector3 spawnPos;
    [SerializeField] float startDelay = 2.0f, intervalDelay = 2.0f;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        spawnPos = new Vector3(25, 0, 0);
        InvokeRepeating("SpawnObstacle", startDelay, intervalDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        if(!playerController.isGameOver)
            Instantiate(obstacle, spawnPos, obstacle.gameObject.transform.rotation);
    }
}
