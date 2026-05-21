using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    private Rigidbody2D rb;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    private void OnEnable()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        rb.linearVelocity = Vector2.down * speed;
    }
}
