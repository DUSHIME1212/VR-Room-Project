using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    [Header("Clock Hands")]
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    [Header("Smooth Movement (Optional)")]
    public bool smoothMovement = false;
    public float smoothSpeed = 5f;

    private void Update()
    {
        // Get current system time
        DateTime currentTime = DateTime.Now;

        // Calculate angles for each hand
        float secondAngle = -currentTime.Second * 6f; // 360 / 60 = 6 degrees per second
        float minuteAngle = -(currentTime.Minute * 6f + currentTime.Second * 0.1f); // Include seconds for smoothness
        float hourAngle = -(currentTime.Hour % 12 * 30f + currentTime.Minute * 0.5f); // 360 / 12 = 30 degrees per hour + minutes offset

        if (smoothMovement)
        {
            // Smooth rotation (optional)
            RotateHandSmoothly(hourHand, hourAngle);
            RotateHandSmoothly(minuteHand, minuteAngle);
            RotateHandSmoothly(secondHand, secondAngle);
        }
        else
        {
            // Direct rotation
            hourHand.localRotation = Quaternion.Euler(0f, 0f, hourAngle);
            minuteHand.localRotation = Quaternion.Euler(0f, 0f, minuteAngle);
            secondHand.localRotation = Quaternion.Euler(0f, 0f, secondAngle);
        }
    }

    private void RotateHandSmoothly(Transform hand, float targetAngle)
    {
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, targetAngle);
        hand.localRotation = Quaternion.Slerp(hand.localRotation, targetRotation, smoothSpeed * Time.deltaTime);
    }
}