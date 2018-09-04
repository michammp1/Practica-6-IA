using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAMove : MonoBehaviour
{
    [SerializeField]
    Transform _destination;
    UnityEngine.AI.NavMeshAgent _navMeshAgent;
    void Start()
    {
        _navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.LogError("El agente de navegación no esta añadido" + gameObject.name);
        }
        else
        {
            SetDestination();
        }
    }

    private void SetDestination()
    {
        Vector3 targetVector = _destination.transform.position;
        _navMeshAgent.SetDestination(targetVector);
    }

    void Update()
    {

    }
}
