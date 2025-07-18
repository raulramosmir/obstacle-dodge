using UnityEngine;

public class MoveBetweenTwoPoints : MonoBehaviour
{
    [Header("Points between which the object will move")]
    [SerializeField] Transform pointA;
    [SerializeField] Transform pointB;

    [Header("Movement speed")]
    [SerializeField] float speed = 3f;

    [Header("Distance threshold for switching direction")]
    [SerializeField] private float switchDistanceThreshold = 0.01f;

    Transform currentTarget;

    void Start()
    {
        currentTarget = pointB;
    }

    void Update()
    {
        if (pointA == null || pointB == null) return;

        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentTarget.position) < switchDistanceThreshold)
        {
            currentTarget = currentTarget == pointA ? pointB : pointA;
        }
    }
}
