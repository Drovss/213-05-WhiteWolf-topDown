using UnityEngine;

public class Meat : MonoBehaviour
{
    public delegate void FindFoodAction();
    public static event FindFoodAction FindFoodEvent;    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (FindFoodEvent != null)
        {
            FindFoodEvent();
        }

        Destroy(gameObject);
    }
}
