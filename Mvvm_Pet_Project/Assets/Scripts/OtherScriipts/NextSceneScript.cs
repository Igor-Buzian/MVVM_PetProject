using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneScript : MonoBehaviour
{
    public void NewScene()
    {
        SceneManager.LoadScene("NewScene");
    }
}
