using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene(2);
    }
}