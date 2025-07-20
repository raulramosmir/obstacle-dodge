using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    [SerializeField] Text lifeCounterText;
    [SerializeField] Text gameOverText;
    [SerializeField] Button restartButton;
    [SerializeField] int lives = 2;

    void Start()
    {
        UpdateLivesText();

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }

        if (restartButton != null)
        {
            restartButton.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            lives--;
            Debug.Log("Remaining lives: " + lives);

            if (lives <= 0)
            {
                Debug.Log("GAME OVER");
                if (lifeCounterText != null)
                {
                    lifeCounterText.gameObject.SetActive(false);
                }
                if (gameOverText != null)
                {
                    gameOverText.gameObject.SetActive(true);
                }
                if (restartButton != null)
                {
                    restartButton.gameObject.SetActive(true);
                }
                // Prevent further player movement when the game is over
                if (TryGetComponent(out Mover mover))
                {
                    mover.DisableMovement();
                }
            }
            else
            {
                UpdateLivesText();
            }
        }
    }

    private void UpdateLivesText()
    {
        if (lifeCounterText != null)
            lifeCounterText.text = "Lives: " + lives;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
