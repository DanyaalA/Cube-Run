using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement pMovement;
    public TextMeshProUGUI tmg;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            pMovement.enabled = false;
            tmg.enabled = true;
        }
    }
}
