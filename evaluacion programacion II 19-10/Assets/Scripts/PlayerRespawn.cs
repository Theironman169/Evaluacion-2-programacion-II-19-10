
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private void Start()
    {
        if (Checkpoint.hasCheckpoint)
        {
            transform.position = Checkpoint.respawnPosition;
        }
    }
}
