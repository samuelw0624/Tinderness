using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatControl : MonoBehaviour
{
    public float swipeSpeed;
    public Transform destination;
    Animator meatAnim;
    bool swipped;

    // Start is called before the first frame update
    void Start()
    {
        meatAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && !swipped)
        {
            //Debug.Log("I ran");
            //float x = transform.position.x + swipeSpeed * Time.deltaTime;s
            //transform.position = new Vector2(x, transform.position.y);
            //transform.Translate(destination.position);
            //LerpMeat(new Vector2(-10, 0), 2);
            meatAnim.Play("MeatLeft");
            swipped = true;
        }
        if(Input.GetKeyDown(KeyCode.D) && !swipped)
        {
            meatAnim.Play("MeatRight");
            swipped = true;
        }
        if (transform.position.x <= -11.5 || transform.position.x >= 11.5)
        {
            //swipped = false;
            Destroy(gameObject);
        }
    }
    IEnumerator LerpMeat(Vector2 targetpos, float duration)
    {
        float time = 0;
        Vector2 startPos = transform.position;
        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPos, targetpos, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetpos;
    }
}
