using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    Transform cam;
    Vector3 camStartpos;
    float distance;
    GameObject[] backgrounds;
    Material[] mat;
    float[] backSpeed;
    float farthestBack;

    [Range(0.01f, 0.05f)]
    public float parallaxSpeed;

    void Start(){
        cam = Camera.main.transform;
        camStartpos = cam.position;

        int backCount = transform.childCount;
        mat = new Material[backCount];
        backSpeed = new float[backCount];
        backgrounds = new GameObject[backCount];

        for(int i = 0; i < backCount - 1; i++){
            backgrounds[i] = transform.GetChild(i).gameObject;
            mat[i] = backgrounds[i].GetComponent<Renderer>().material;
        }

        BackSpeedCalculate(backCount);
    }

    void BackSpeedCalculate(int backCount){
        for(int i = 0; i < backCount - 1; i++){
            if(backgrounds[i].transform.position.z - cam.position.z > farthestBack){
                farthestBack = backgrounds[i].transform.position.z - cam.position.z;
            }
        }

        for(int i = 0; i < backCount - 1; i++){
            backSpeed[i] = 1 - (backgrounds[i].transform.position.z - cam.position.z) / farthestBack;
        }
    }

    private void LateUpdate() {
        distance = cam.position.x - camStartpos.x;
        transform.position =  new Vector3(cam.position.x, transform.position.y, 0);
        
        for(int i = 0; i < backgrounds.Length - 1; i++){
            float speed = backSpeed[i] * parallaxSpeed;
            mat[i].SetTextureOffset("_MainTex", new Vector2(distance, 0) * speed);
        }
    }
}