using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionHandler : MonoBehaviour
{
    Vector2 currentCheckpointPosition;
    void Start(){
        GameManager.instance.CheckSaveFile();
        currentCheckpointPosition = playerPositionData.position;
    }

#region Condition
    public void OnCheckpoint(GameObject collider){
        Vector2 newCheckpointPosition = collider.transform.position;
        currentCheckpointPosition = newCheckpointPosition;
        SavePosition(currentCheckpointPosition);
    }

    public void OnEnemy(){
        ChangePlayerPosition(currentCheckpointPosition);
    }

    public void OnFinish(){
        GameManager.instance.ChangeLevel(1);
        GameManager.instance.ChangeScene(0);
    }
#endregion

#region SaveLoad
    public TransformData playerPositionData;
    private void LoadPosition(){
        transform.position = playerPositionData.position;
    }

    private void SavePosition(Vector2 newPosition){
        playerPositionData.position = newPosition;
    }
#endregion

    private void ChangePlayerPosition(Vector2 newPosition){
        transform.position = newPosition;
    }
}