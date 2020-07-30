using UnityEngine;

public class playercollision : MonoBehaviour
{
    public PlayerMove movement;
    public GameManager gamemanager;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}