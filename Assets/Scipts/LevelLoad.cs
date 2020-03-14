using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
    
{
    [SerializeField] int timeToWait = 4;
    
    //looks for current scene
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {//Obtains active scene
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {//Start Load time
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        //wait to load
        LoadNextScene();

    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
