using UnityEngine;

public class SpriteManager : MonoBehaviour
{

    public Sprite[] blockSprites;

    public Sprite getRandomBlockSprite()
    {
        return blockSprites[Random.Range(0, blockSprites.Length)];
    }

}
