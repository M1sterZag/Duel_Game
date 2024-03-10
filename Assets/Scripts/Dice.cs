using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public float step = 1.0f; // Величина шага
    public float smoothSpeed = 5.0f; // Скорость плавного перемещения

    private Vector3 targetPosition;
    private bool isMoving = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovePlayer(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovePlayer(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovePlayer(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovePlayer(Vector3.back);
        }

        if (isMoving)
        {
            SmoothMove();
        }
    }

    void MovePlayer(Vector3 direction)
    {
        targetPosition = transform.position + direction * step;
        isMoving = true;
    }

    void SmoothMove()
    {
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPosition) < 0.001f)
        {
            isMoving = false;
        }
    }
}
