using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestruction : MonoBehaviour
{
    [SerializeField] private string victorySceneName = "Victory"; // Nombre de la escena de victoria

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // Destruye el coche enemigo
            Destroy(collision.gameObject); // Destruye la bala
            LoadVictoryScene();
        }
    }

    private void LoadVictoryScene()
    {
        SceneManager.LoadScene(victorySceneName);
    }
}





