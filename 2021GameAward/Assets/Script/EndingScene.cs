﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("joystick button 0"))
        {
            ChangeScene();
        }
    }

    void ChangeScene()
    {
        //SceneManager.LoadScene("SelectScene");
        FadeManager.Instance.LoadScene("TItleScene", 0.6f);
    }

    public void EndingSerect()
    {
        ChangeScene();
    }
}
