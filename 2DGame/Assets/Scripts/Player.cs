using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門了");

    }

}
