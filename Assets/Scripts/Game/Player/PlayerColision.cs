using UnityEngine;
using UnityEngine.Events;

public class PlayerColision : MonoBehaviour
{
    public UnityEvent FindFoodEvent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Meat>())
        {
            FindFoodEvent.Invoke();
        }
    }
}
