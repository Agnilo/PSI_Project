using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    [SerializeField]Transform spawnPoint;
    public AudioSource ouch;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))  
            ouch.Play();
            col.transform.position = spawnPoint.position;
        Score.scoreAmount = 0;
    }
    private void Start()
    {
        ouch = GetComponent<AudioSource>();
    }
}

