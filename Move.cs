using MyLibrary;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 5f;

    void Update()
    {
        transform.Translate(Movement.KeyMoveVector(speed));
    }
}