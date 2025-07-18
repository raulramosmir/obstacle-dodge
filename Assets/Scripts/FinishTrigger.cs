using UnityEngine;
using UnityEngine.UI;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] Mover playerMover;
    [SerializeField] Text winText;
    [SerializeField] Button restartButton;

    void Start()
    {
        if (winText != null) winText.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        if (playerMover != null) playerMover.enabled = false;
        if (winText != null) winText.gameObject.SetActive(true);
        if (restartButton != null) restartButton.gameObject.SetActive(true);
    }
}