using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ");
        transform.position = Vector3.zero;
        speed = 3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ariel Alejandro Vega");
    }

    public void Move(float horizontalInput, float verticalInput)
    {
        
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);
    }
}
