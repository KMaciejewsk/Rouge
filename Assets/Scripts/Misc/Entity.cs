using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private bool isSentient = false;

    public bool IsSentient { get => isSentient; }

    void Start()
    {
        if (GetComponent<Player>())
        {
            GameManager.instance.InsertEntity(this,0);
        }
        else if (IsSentient)
        {
            GameManager.instance.AddEntity(this);
        }
    }

    public void Move(Vector2 direction, float speed)
    {
        transform.position += (Vector3)direction*speed;
    }
}
