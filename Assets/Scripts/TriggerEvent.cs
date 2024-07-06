using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum TypeTag{
    Player, Trap, Checkpoint, Finish, Trigger, Enemy,
}

public class TriggerEvent : MonoBehaviour
{
    public TypeTag targetTag;
    public UnityEvent<GameObject> OnTrigger;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == targetTag.ToString()){
            OnTrigger?.Invoke(other.gameObject);
        }
    }
}