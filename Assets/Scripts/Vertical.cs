using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    public int length;
    private Transform trans;

    private float? oldMousePos;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        trans.localScale = new Vector2(1, length);
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
        float mp = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        float? move_y = null;
        if (oldMousePos == null)
            oldMousePos = mp;
        else if (oldMousePos != mp)
            move_y =  mp - oldMousePos;
        if (oldMousePos == mp)
            move_y = null;
        if (move_y != null)
            trans.position = new Vector2(trans.position.x, trans.position.y + (float)move_y);
        oldMousePos = mp;
    }
}
