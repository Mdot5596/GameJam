using UnityEngine;

public class EndGameTeleport : MonoBehaviour
{
    public Transform endGameRoomLocation; 
    public GameObject promptUI;           
    public string playerTag = "Player";

    private bool playerInRange = false;
    private Transform player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInRange = true;
            player = other.transform;
            if (promptUI != null)
                promptUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            playerInRange = false;
            if (promptUI != null)
                promptUI.SetActive(false);
            player = null;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (endGameRoomLocation != null && player != null)
            {
                player.position = endGameRoomLocation.position;
                if (promptUI != null)
                    promptUI.SetActive(false);
            }
        }
    }
}
