using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int entranceScene;

    private AudioManager audioManager;


    // tiempo
    private bool gameStarted;
    public float limitTime;
    public Canvas canvas;
    private Canvas _canvas;
    private Text timer;
    private int terminados;
    private Text score;

    // Manejo escenas minijuegos
    public int level;
    public bool changeScene;
    private TransicionNivel transicion;
    private float mainVolume = 1f;

    // Juego de la brocheta
    public int pinchados;

    // Juego del batido
    public int cortes;

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
        _canvas = Instantiate(canvas);
        Text[] texts = _canvas.gameObject.GetComponentsInChildren<Text>();
        timer = texts[0];
        score = texts[1];

        gameStarted = false;
        /*
        audioManager = AudioManager.instance;
        audioManager.PlaySound("Test");
        audioManager.ChangeVolume(mainVolume);
        */
    }

    private void Update()
    {

        if(limitTime < 0f)
        {
            Debug.Log("Fin del juego");
        }

        /*
        if (Input.GetKeyDown(KeyCode.P))
        {
            startGame();
        }*/

        if (gameStarted)
        {
            /*
            if (Input.GetKeyDown(KeyCode.P))
            {
                Terminado();
            }*/
            limitTime -= Time.deltaTime;
            timer.text = ((int)limitTime).ToString();
        }

        if(pinchados == 4)
        {
            startTransition();
            pinchados++; // evitar llamarlo dos veces
        }

        if (cortes == 1 && level == 1)
        {
            startTransition();
            cortes = 0;
        }else if(cortes == 3 && level == 2)
        {
            startTransition();
            cortes = 0;
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


    public void SetVolume(Slider slider)
    {
        mainVolume = slider.value;
        Debug.Log(mainVolume);
        audioManager.ChangeVolume(mainVolume);

    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }


    public void Terminado()
    {
        terminados++;
        score.text = "Atendidos: "+ terminados.ToString();
    }

    public void startGame()
    {
        gameStarted = true;
    }

}
