using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Horizontal : MonoBehaviour
{
    public int length;
    private float? oldMousePos = null;
    
    private Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        trans.localScale = new Vector2(length, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseUp()
    {
        oldMousePos = null;
    }

    private void OnMouseDrag()
    {
        float mp = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float? move_x = null;
        if (oldMousePos == null)
            oldMousePos = mp;
        else if (oldMousePos != mp)
            move_x =  mp - oldMousePos;
        if (oldMousePos == mp)
            move_x = null;
        if (move_x != null)
            trans.position = new Vector2(trans.position.x + (float)move_x, trans.position.y);
        oldMousePos = mp;
    }
}
