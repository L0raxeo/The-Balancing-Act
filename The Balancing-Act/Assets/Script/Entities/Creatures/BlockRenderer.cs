using UnityEngine;

public class BlockRenderer : MonoBehaviour
{

    void Start()
    {
        setSprite();
        setSize();
        setTorque();
    }

    private void setSprite()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = GameObject.FindObjectOfType<SpriteManager>().getRandomBlockSprite();
    }

    private void setSize()
    {

    }

    private void setTorque()
    {

    }

}
