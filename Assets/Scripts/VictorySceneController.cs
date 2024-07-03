using UnityEngine;
using UnityEngine.SceneManagement;

public class VictorySceneController : MonoBehaviour
{
    public void RestartGame()
    {
        // Asumiendo que la escena del juego es la primera en la lista de Build Settings
        SceneManager.LoadScene(0);
    }
}

