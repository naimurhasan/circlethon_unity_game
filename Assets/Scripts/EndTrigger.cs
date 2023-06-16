using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(){
        FindObjectOfType<GameManager>().CompleteGame();

    }
}
