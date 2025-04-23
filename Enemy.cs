using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float speed = 0.5f;
    public GameEnding gameEnding;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (player !=null);
        {
            Vector3 direction = (player.position - transform.position).normalized;

            transform.position += direction * speed* Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            gameEnding.CaughtPlayer();
        }
    }
}
