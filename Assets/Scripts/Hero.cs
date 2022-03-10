using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Hero : MonoBehaviour
{
    public NavMeshAgent agent;
    public Animator theAnimator;

	void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) agent.SetDestination(hit.point);
        }
        theAnimator.SetFloat("speed", agent.velocity.magnitude);
	}
}
