/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerEnemy : MonoBehaviour
{

    private bool checkTrigger;
    public float speed;
    public Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("hero").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (checkTrigger)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

