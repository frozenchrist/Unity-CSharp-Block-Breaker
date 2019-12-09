using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneLoader : MonoBehaviour
{


    public void LoadNextScene() {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentSceneIndex + 1);

        Debug.Log("Scene#: " + currentSceneIndex++ + " loaded!!!");

    }


    public void LoadStartScene()
    {


        SceneManager.LoadScene(0);



    }


    public void onPressQuit() {

        Application.Quit();
    
    }


}
