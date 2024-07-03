using UnityEngine;
using UnityEngine.SceneManagement;

public class DefeatSceneController : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Cargar la escena anterior
    }
}

