using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //cached reference
    Level level;

   

    private void Start()
    {

        level = FindObjectOfType<Level>();

        level.countBreakableBlocks();

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        destroyBlocks();

    }

    private void destroyBlocks()
    {
        Destroy(gameObject);

        level.countDestroyedBlocks();

        FindObjectOfType<GameStatus>().addCurrentScore();


    }




}
