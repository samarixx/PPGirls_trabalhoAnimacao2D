using UnityEngine;

public class Jogador : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float velocidadeMovimento;
    
    public SpriteRenderer spriteRenderer;
    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 velocidade = this.rigidbody2d.linearVelocity;
        velocidade.x = horizontal * this.velocidadeMovimento;
        this.rigidbody2d.linearVelocity = velocidade;

        if (velocidade.x > 0)
        {
            this.spriteRenderer.flipX = false;
        }
        else if (velocidade.x < 0)
        {
            this.spriteRenderer.flipX = true;
        }
    }
}