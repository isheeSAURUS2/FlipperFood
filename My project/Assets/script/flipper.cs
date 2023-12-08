using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{
    [SerializeField] private float timer = 0f;
    private float delay = 10f;
    [SerializeField] private GameObject left-wall;
    [SerializeField] private GameObject right-wall;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay){
            timer = 0;
            //do iets
        }

        if (Input.GetKeyDown("k")){
            //doe iets
        }
    }
}
