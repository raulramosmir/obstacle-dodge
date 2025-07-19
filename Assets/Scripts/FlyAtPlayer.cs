using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    [SerializeField] float destroyThreshold = 0.01f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void OnEnable()
    {
        if (player != null)
        {
            playerPosition = player.position;
        }
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    void DestroyWhenReached()
    {
        if (Vector3.Distance(transform.position, playerPosition) < destroyThreshold)
        {
            Destroy(gameObject);
        }
    }
}
