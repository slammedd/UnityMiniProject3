using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public bool moving = true;
    public float moveSpeed;

    private PlayerController player;
    private float baseMoveSpeed;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        baseMoveSpeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(moving == true)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if(transform.position.x <= -55)
        {
            Vector3 newPosition = new Vector3(55, Random.Range(-8, 20), 0);
            transform.position = newPosition;
        }

        if(player.score >= 3)
        {
            moveSpeed = baseMoveSpeed * 1.2f;
        }

        else if (player.score >= 6)
        {
            moveSpeed = baseMoveSpeed * 1.5f;
        }

        else if(player.score >= 10)
        {
            moveSpeed = baseMoveSpeed * 1.8f;
        }
    }
}
