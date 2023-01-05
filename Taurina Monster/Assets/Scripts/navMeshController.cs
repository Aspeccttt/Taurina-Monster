using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navMeshController : MonoBehaviour
{
    private GameObject player;
    private List<Transform> destination;
    private NavMeshAgent agent;
    private bool state;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        destination = new List<Transform>();
        foreach (GameObject wp in GameObject.FindGameObjectsWithTag("Waypoints"))
        {
            destination.Add(wp.transform);
        }
        agent.SetDestination(GetNextWaypoint().position);
        state = false;
    }

    private Transform GetNextWaypoint()
    {
        Transform nextWp = destination[Random.Range(0, destination.Count)];
        return nextWp;
    }

    void Update()
    {
        //Debug.Log("Current state is " + state);
        Transform wp;

        if (state == false)
        {
            //Debug.Log("STATE IS FALSE");
            if (agent.remainingDistance <= 1)
            {
                do
                {
                    wp = GetNextWaypoint();
                } while (agent.destination == wp.position);
                agent.SetDestination(wp.position);
            }
        }
        if (state == true)
        {
            //Debug.Log("STATE IS TRUE");
            Transform playerPos = GetNewPlayerPos();
            if (agent.destination != playerPos.position)
            {
                playerPos = GetNewPlayerPos();
                agent.SetDestination(playerPos.position);
            }
        }
    }


    private Transform GetNewPlayerPos()
    {
        Transform newPlayerPos = player.GetComponent<Transform>();
        return newPlayerPos;
    }

    public void changeState(bool _state)
    {
        state = _state;
    }
}
