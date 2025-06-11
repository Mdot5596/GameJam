using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnPickupWithKey : MonoBehaviour
{
    public Transform teleportTarget;
    public string playerTag = "Player";
    public GameObject promptUI; // Assign your UI text object (e.g., "Press E to pick up")

    private bool isPlayerInRange = false;
    private Transform player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            isPlayerInRange = true;
            player = other.transform;
            if (promptUI != null)
                promptUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            isPlayerInRange = false;
            if (promptUI != null)
                promptUI.SetActive(false);
            player = null;
        }
    }

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            player.position = teleportTarget.position;

            if (promptUI != null)
                promptUI.SetActive(false);

            Destroy(gameObject); // remove the pickup item
        }
    }
}
