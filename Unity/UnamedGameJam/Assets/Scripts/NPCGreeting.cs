using UnityEngine;

public class NPCGreeting : MonoBehaviour
{
    public AudioSource helloAudio;
    private bool hasSaidHello = false;

    void OnTriggerEnter(Collider other)
    {
        if (!hasSaidHello && other.CompareTag("Player"))
        {
            helloAudio.Play();
            hasSaidHello = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasSaidHello = false; // allows replay next time
        }
    }
}
