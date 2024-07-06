using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    static float t = 0.0f;
    public float distance;
    public float speed;
    [Header("Flip Position")]
    public float posXL, posXR;
    private float originalPos;
    private SpriteRenderer sprite;
    void Start(){
        originalPos = transform.position.x;
        sprite = GetComponent<SpriteRenderer>();
    }

    void SpriteFlip(){
        if(transform.localPosition.x < posXL)
            sprite.flipX = true;
        else if(transform.localPosition.x > posXR)
            sprite.flipX = false;
    }

    void Update(){
        var md = Mathf.Sin(t) * distance;
        var x = originalPos + md;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
        t += speed * Time.deltaTime;
        SpriteFlip();
    }
}