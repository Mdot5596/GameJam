using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnPickup : MonoBehaviour
{
    public Transform teleportTarget;
    public string playerTag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            other.transform.position = teleportTarget.position;
            Destroy(gameObject);
        }
    }
}
