using System.Collections;using System.Collections.Generic;using UnityEngine;public class bg : MonoBehaviour{    private float speed = .3f;    private Vector2 offset;

    // Update is called once per frame
    void Update()    {
        if (kusScript.GameOver == false && kusScript.start == true)        {
            offset = new Vector2(Time.time * speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
    }}