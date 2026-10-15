using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private float moveSpeed = 5f;

    private Rigidbody2D rb;

    private Vector3 respawnPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        respawnPosition = transform.position;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);
    }

    
    public void SetRespawnPoint(Vector3 position)
    {
        respawnPosition = position;
        Debug.Log("復活地点更新");
    }

    public void Respawn()
    {
        transform.position = respawnPosition;

        rb.linearVelocity = Vector2.zero;

        Debug.Log("リスポーン");
    }
}
