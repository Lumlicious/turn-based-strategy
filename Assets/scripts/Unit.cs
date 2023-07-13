using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Animator unitAnimator;
    private Vector3 targetPosition;

    private void Awake()
    {
        targetPosition = transform.position;
    }

    private void Update()
    {
        float stoppingDistance = .1f;

        // To prevent never reaching destination, move to point if close enough
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            // Just want direction so normalize
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            // Increase movement speed (too slow)
            float moveSpeed = 4f;
            // Multiply by Time.deltaTime to make framerate independent
            transform.position += moveDirection * moveSpeed * Time.deltaTime;

            float rotateSpeed = 10f;
            transform.forward = Vector3.Lerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
            unitAnimator.SetBool("IsWalking", true);
        }
        else
        {
            unitAnimator.SetBool("IsWalking", false);
        }
    }
    public void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
