using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            meshRenderer.material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
