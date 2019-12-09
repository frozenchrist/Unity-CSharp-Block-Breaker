using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

 

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        GetComponent<AudioSource>().Play();

        Invoke("loadGameOverScene", 0.6f);
        
    }


    private void loadGameOverScene() {



        SceneManager.LoadScene("Game Over");

    }

}
