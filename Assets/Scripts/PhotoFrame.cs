using UnityEngine;

public class PhotoFrame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = spriteRenderer.color;

        color.a = 0.1f + Mathf.PingPong(Time.time * 0.5f, 0.4f);

        spriteRenderer.color = color;
    }
}
