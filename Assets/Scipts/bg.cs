﻿using System.Collections;

    // Update is called once per frame
    void Update()
        if (kusScript.GameOver == false && kusScript.start == true)
            offset = new Vector2(Time.time * speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
    }