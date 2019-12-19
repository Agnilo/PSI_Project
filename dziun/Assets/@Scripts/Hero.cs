using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour
{

    [System.Serializable]
    public class PlayerStats
    {
        public int Health = 100;
    }

    
    public PlayerStats playerStats = new PlayerStats();

    public int fallBoundary = -20;

    public AudioSource click;

    void Update()
    {
       
        if (transform.position.y <= fallBoundary)
        {
            DamagePlayer(9999999);
            Score.scoreAmount = 0;
        }
    }

    public void DamagePlayer(int damage)
    {
        playerStats.Health -= damage;
        if (playerStats.Health <= 0)
        {
            GameMaster.KillPlayer(this);
            Score.scoreAmount = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.name)
        {
            case "potato":
                Score.scoreAmount += 1;
            Destroy(collision.gameObject);
                click.Play();
            break; 
        }
    }

    private void Start()
    {
        click = GetComponent<AudioSource>();
    }

}