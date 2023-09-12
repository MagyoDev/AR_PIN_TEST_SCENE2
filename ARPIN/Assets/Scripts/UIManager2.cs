using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using DG.Tweening;
using System;

public class UIManager2 : MonoBehaviour
{
    [SerializeField] private GameObject Scene2CodeMenuCanvas;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnScene2CodeMenu += ActivateScene2CodeMenu;
    }

    private void ActivateScene2CodeMenu()
    {
        Scene2CodeMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

    }
}
