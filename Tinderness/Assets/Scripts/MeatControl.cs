using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatControl : MonoBehaviour
{
    public float swipeSpeed;
    public Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("I ran");
            //float x = transform.position.x + swipeSpeed * Time.deltaTime;
            //transform.position = new Vector2(x, transform.position.y);
            transform.Translate(destination.position);
        }    
    }
}
