using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
    
    public void ChangeScene(string scene) {
        SceneManager.LoadScene(scene);
    }

    public void ChangeScene(int sceneIndex) {
        SceneManager.LoadScene(sceneIndex);
    }

    public void NextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}