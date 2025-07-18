using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    public enum StateMachine
    {
        Idle,
        Engage
    }

    public StateMachine currentState;
    public float speed = 3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case StateMachine.Idle:
                Idle();
                break;
            case StateMachine.Engage:
                Engage();
                break;
        }

        bool playerSeen = Vector3.Distance(transform.position, player.position) < 10f;

        if (!playerSeen && currentState != StateMachine.Idle)
        {
            currentState = StateMachine.Idle;
        }
        else if (playerSeen && currentState != StateMachine.Engage)
        {
            currentState = StateMachine.Engage;
        }
        /*if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }*/
    }

    void Idle()
    {
        return;
    }

    void Engage()
    {
        navMeshAgent.SetDestination(player.position);
    }

}
