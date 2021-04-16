using UnityEngine;

public class BlockRenderer : MonoBehaviour
{

    void Start()
    {
        setSprite();
        setPosition();
        setSize();
        setTorque();
    }

    private void setPosition()
    {
        float xRan = Random.Range(-3, 3);
        transform.position = new Vector3(xRan, 5f, 0f); // y will be changed to just above the camera
    }

    private void setSprite()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = GameObject.FindObjectOfType<SpriteManager>().getRandomBlockSprite();
    }

    private void setSize()
    {
        float size = Random.Range(0.75f, 2f);
        transform.localScale = new Vector3(size, size, 1);
    }

    private void setTorque()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        float torque = Random.Range(-25, 25);
        rb.AddTorque(torque);
    }

}
