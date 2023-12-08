using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{
    [SerializeField] private float timer = 0f;
    [SerializeField] private GameObject leftWall;
    [SerializeField] private GameObject rightWall;
    private float delay = 10f;
    [SerializeField] private bool CanClick = true;
    [SerializeField] private bool HasFood = false;
    
    [SerializeField] private Transform ThisTransform;
    [SerializeField] private Transform FoodTransform;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay){
            timer = 0;
            //do iets
        }

        if (Input.GetKeyDown("k") && CanClick && HasFood){
            transform.Rotate(0,0,-45);
            rightWall.SetActive(false);
            CanClick = false;
        }
        if (Input.GetKeyDown("d") && CanClick && HasFood){
            transform.Rotate(0,0,45);
            leftWall.SetActive(false);
            CanClick = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "food"){
            HasFood = true;
            FoodTransform.parent = ThisTransform;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "food" && HasFood){
            HasFood = false;
            FoodTransform.parent = null;
        }
    }
}
