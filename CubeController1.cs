﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController1 : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    { //turn the previously clicked cube white
        if (GameController.activeCube != null)
        {
            GameController.activeCube.GetComponent<Renderer>().material.color = Color.white;
        }
        //now turn the currently clicked cube red 
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        GameController.activeCube = gameObject;
    }
}
