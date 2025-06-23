using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform[] spawnPonit;

    float timer;
    void Awake()
    {
        spawnPonit = GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.5f) {
            timer = 0;
            Spawn();
        }
    } 

    void Spawn()
    {
        GameObject enemy = GameManager.instance.Pool.Get(UnityEngine.Random.Range(0, 15));
        enemy.transform.position = spawnPonit[UnityEngine.Random.Range(1, spawnPonit.Length)].position;
    }
}

