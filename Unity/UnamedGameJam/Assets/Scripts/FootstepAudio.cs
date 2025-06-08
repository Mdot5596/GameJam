using UnityEngine;

public class FootstepAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip footstepClip;

    private Rigidbody rb;
    private PlayerMovement playerMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMovement = GetComponent<PlayerMovement>();

        audioSource.clip = footstepClip;
        audioSource.loop = true;
    }

    void Update()
    {
        bool isMoving = new Vector3(rb.velocity.x, 0, rb.velocity.z).magnitude > 0.2f;

        if (playerMovement.IsGrounded && isMoving)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }
}
