using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField inputfield;
    public string name;

    public static MenuManager Instance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startGame()
    {
        name = inputfield.text;
        SceneManager.LoadScene(1);
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
