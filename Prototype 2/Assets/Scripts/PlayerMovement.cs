using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private readonly float speed = 20f;
    private readonly int limitX = 15;

    [SerializeField] private GameObject FoodPreFab;

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.Translate(inputX * speed * Time.deltaTime * Vector3.right);    
    
        if(transform.position.x >= limitX)
        {
            transform.position = Vector3.right * limitX;
        }
        else if(transform.position.x <= -limitX)
        {
            transform.position = Vector3.left * limitX;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(FoodPreFab, transform.position, FoodPreFab.transform.rotation);
        }
    }   
}   