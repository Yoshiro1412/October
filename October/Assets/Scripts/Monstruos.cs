using UnityEngine;
using UnityEngine.SceneManagement;


[System.Serializable]
public class Monster
{
    public string name;
    public GameObject prefab;
    public int[] miniJuegos;
}

public class Monstruos : MonoBehaviour
{
    [SerializeField]
    public Monster[] monstruos;
    private Monster current;

    public void Start()
    {
        current = GetMonster();
        Instantiate(current.prefab,transform);
    }

    public Monster GetMonster()
    {
        int index = Random.Range(0, monstruos.Length);
        return monstruos[index];
    }

    private void OnMouseDown()
    {
        int index = Random.Range(0, current.miniJuegos.Length);
        Debug.Log("Cambiando...");
        SceneManager.LoadScene(current.miniJuegos[index]);
    }
}