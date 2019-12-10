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

    public void reloadLevel1() {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene("Level 1");
    
    }


    public void reloadLevel2()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene("Level 2");

    }


    public void onPressQuit() {

        Application.Quit();
    
    }


}
