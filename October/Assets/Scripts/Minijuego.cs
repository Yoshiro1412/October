using UnityEngine;
using UnityEngine.SceneManagement;

public class Minijuego : MonoBehaviour
{
    public int sceneIndex;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
