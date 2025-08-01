using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    bool hasDropped = false;
    float startTime;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        if (myMeshRenderer != null)
        {
            myMeshRenderer.enabled = false;
        }
        if (myRigidBody != null)
        {
            myRigidBody.useGravity = false;
        }

        startTime = Time.time;
    }

    void Update()
    {
        if (!hasDropped && Time.time - startTime > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;
            hasDropped = true;
        }
    }
}
