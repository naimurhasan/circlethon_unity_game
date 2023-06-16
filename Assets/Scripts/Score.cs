using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText((player.position.z+7).ToString("0"));
    }
}
