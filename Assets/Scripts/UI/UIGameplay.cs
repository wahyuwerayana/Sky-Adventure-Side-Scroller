using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameplay : MonoBehaviour
{
    public Button buttonResume, buttonPause, buttonExit;
    public GameObject panelPause;
    void Start(){
        buttonPause.onClick.AddListener(HandleButtonClick);
        buttonResume.onClick.AddListener(HandleButtonClick);
        buttonExit.onClick.AddListener(()=>GameManager.instance.ChangeScene(0));
    }

    void HandleButtonClick(){
        if(GameManager.instance.isPaused == true){
            GameManager.instance.ResumeGame();
            buttonPause.gameObject.SetActive(true);
            panelPause.SetActive(false);
        } else{
            GameManager.instance.PauseGame();
            buttonPause.gameObject.SetActive(false);
            panelPause.SetActive(true);
        }
    }
}