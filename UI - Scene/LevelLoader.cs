using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] Image slider;
    [SerializeField] int Index;

    void Start()
    {
        StartCoroutine(loadAsync(Index));
    }
    public void loadLevel(int sceneIndex)
    {
        StartCoroutine(loadAsync(sceneIndex));
    }

    IEnumerator loadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.fillAmount = progress;
            yield return null;
        }
        
    }
}
