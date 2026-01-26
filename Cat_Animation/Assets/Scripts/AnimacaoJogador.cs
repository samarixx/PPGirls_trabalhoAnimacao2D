using UnityEngine;

public class AnimacaoJogador : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    
    [SerializeField]
    private Rigidbody2D rigidbody;

    
    void Update()
    {
        float velocidadeX = Mathf.Abs(this.rigidbody.linearVelocity.x);
        if (velocidadeX > 0)
        {
            this.animator.SetBool("Correndo", true);
        }
        else
        {
            this.animator.SetBool("Correndo", false);
        }
    }
}
