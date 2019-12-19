
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameMaster gameMaster;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameMaster.CompleteLevel();
    }
    
}
