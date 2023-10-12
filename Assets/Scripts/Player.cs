using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed;
    private float limitRangeX;
    private float limitRangeY;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ");
        transform.position = Vector3.zero;
        speed = 3.5f;
        limitRangeX = 8f;
        limitRangeY = 4.15f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ariel Alejandro Vega");
    }

    public void Move(float horizontalInput, float verticalInput)
    {
        if(gameObject.transform.position.x < -limitRangeX)
        {
            gameObject.transform.position = new Vector3(-limitRangeX, 
                                                        gameObject.transform.position.y, 
                                                        gameObject.transform.position.z);
        }else if (gameObject.transform.position.x > limitRangeX)
        {
            gameObject.transform.position = new Vector3(limitRangeX,
                                                        gameObject.transform.position.y,
                                                        gameObject.transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        }

        if (gameObject.transform.position.y < -limitRangeY)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,
                                                        -limitRangeY,
                                                        gameObject.transform.position.z);
        }
        else if (gameObject.transform.position.y > limitRangeY)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x,
                                                        limitRangeY,
                                                        gameObject.transform.position.z);
        }
        else
        {
            transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
        }

        Debug.Log(transform.position);
    }
}
