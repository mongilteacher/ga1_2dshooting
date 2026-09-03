using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        Vector2 direction = Vector2.down;

        transform.Translate(direction * _moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}