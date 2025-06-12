using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public float chaseDistance = 5f;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.position);
        animator.SetBool("isRunning", dist < chaseDistance);
    }
}
