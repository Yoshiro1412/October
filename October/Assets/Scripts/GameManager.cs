using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int entranceScene;

    private AudioManager audioManager;


    // Manejo escenas minijuegos
    public int level;
    public bool changeScene;
    private TransicionNivel transicion;

    // Juego de la brocheta
    public int pinchados;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioManager = AudioManager.instance;
        audioManager.PlaySound("Test");
    }

    private void Update()
    {
        if(pinchados == 4)
        {
            startTransition();
            pinchados++; // evitar llamarlo dos veces
        }
    }

    public void BackToEntrance()
    {
        SceneManager.LoadScene(entranceScene);
    }

    public void startTransition()
    {
        Debug.Log("transicion");
        transicion = FindObjectOfType<TransicionNivel>();
        transicion.MoveToNextPoint();
    }


}
