using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float lengthUnit = 16f;

    float fixedMouseY = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.mousePosition.x / Screen.width * lengthUnit ;

        Vector2 paddlePos = new Vector2(Mathf.Clamp(mouseX, 0.5f, 15.5f), fixedMouseY);

        transform.position = paddlePos;


       

    }
}
