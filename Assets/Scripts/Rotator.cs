using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Rotator : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI PlayerPosition;
    public TextMeshProUGUI PlayerVelocity;

    private Vector3 lastPosition;
    private Vector3 velocity;
    private void Start()
    {
        lastPosition = player.position;
    }

        
    void Update()
    {

        velocity = (player.position - lastPosition) / Time.deltaTime;

        UpdatePlayerPositionAndVelocity();

        lastPosition = player.position;

        transform.Rotate(new Vector3(15,30,45)  * Time.deltaTime);
    }

    private void UpdatePlayerPositionAndVelocity()
    {
        PlayerPosition.text = "Position: " + player.position.ToString("0.00");

        float speed = velocity.magnitude;

        PlayerVelocity.text = "Speed: " + speed.ToString("0.00") + " units/sec";
    }
}
