using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;

    public GameObject EndGame;
    public GameObject figure;

    public void CompleteLevel()
    {
        EndGame.SetActive(true);
        Time.timeScale = 0f;
        figure.SetActive(false);
    }

    void Start () {
		if (gm == null) {
			gm = GameObject.FindGameObjectWithTag ("GM").GetComponent<GameMaster>();
		}
       
	}

    public Hero hero;
	public Transform playerPrefab;
	public Transform spawnPoint;
	public int spawnDelay = 2;
    

	public IEnumerator RespawnPlayer () {
		Debug.Log ("TODO: Add waiting for spawn sound");
		yield return new WaitForSeconds (spawnDelay);

		Instantiate (playerPrefab, spawnPoint.position, spawnPoint.rotation);
		Debug.Log ("TODO: Add Spawn Particles");
	}

	public static void KillPlayer (Player player) {
		Destroy (player.gameObject);
		gm.StartCoroutine (gm.RespawnPlayer());
	}

    internal static void KillPlayer(Hero hero)
    {
        Destroy(hero.gameObject);
        gm.StartCoroutine(gm.RespawnPlayer());
        //throw new NotImplementedException();
    }

    internal static void KillEnemy (Enemy123 enemy123)
    {
        Destroy(enemy123.gameObject);

    }

}