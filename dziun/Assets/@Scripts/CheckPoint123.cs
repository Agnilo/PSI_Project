using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint123 : MonoBehaviour
{
    public bool checkpointReached;
    public GameObject levelReached;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            checkpointReached = true;
            levelReached.SetActive(true);
        }
        else
        {
            levelReached.SetActive(false);
        }
    }
}
