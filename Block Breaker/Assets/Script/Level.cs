using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level : MonoBehaviour
{

    [SerializeField] int breakableBlocks;

    SceneLoader scenceLoader;


    private void Start()
    {
       scenceLoader = FindObjectOfType<SceneLoader>();
    }

    

    public void countBreakableBlocks() {

        breakableBlocks++;

    }


    public void countDestroyedBlocks() {

        breakableBlocks--;

        if (breakableBlocks <= 0) {

            //Invoke("loadLevel2", 0.5f);

            scenceLoader.LoadNextScene();
        
        }

    }

    

    public void loadLevel2() {

        SceneManager.LoadScene("Level 2");
    
    }

  

}
