using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public Transform goal;

    public GameObject parent;

    void Start()
    {
        
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        Object[] agents = GetComponentsInChildren<Object>();
        Debug.Log(agents.Length);
        for( int i = 0; i < agents.Length; i++)
        {
            //agents[i].GetComponent<NavMeshAgent>().destination = goal.position;
        }
        //agent.destination = goal.position;
    }
}