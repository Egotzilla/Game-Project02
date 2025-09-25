using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target to Follow")]
    public Transform player;        // drag your Player into this field in Inspector

    [Header("Offset Settings")]
    public Vector3 offset = new Vector3(0f, 3f, -6f); // adjust height & distance
    public float followSpeed = 5f;  // smoothness

    private void LateUpdate()
    {
        if (player == null) return;

        // Desired position
        Vector3 targetPosition = player.position + player.TransformDirection(offset);

        // Smooth follow
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        // Optionally keep looking at the player (disable if you don't want this)
        // transform.LookAt(player);
    }
}
