using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    public int length;
    private Transform trans;
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

    private void OnMouseDrag()
    {
        Vector3 mp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        trans.position = new Vector2(trans.position.x, mp.y);
    }
}
