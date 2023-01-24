using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public enum RotationAxes
    {
        mouseXAndY = 0,
        mouseX = 1,
        mouseY = 2
    }

    public RotationAxes axes = RotationAxes.mouseXAndY;
    public float sensitivityHor = 9.0f;

    void Update()
    {
        if (axes == RotationAxes.mouseX)
        {
            transform.Rotate(0, Input.GetAxis("mouseX") * sensitivityHor, 0);
        } else if (axes == RotationAxes.mouseY)
        {
            // Это поворот по вертикальой плоскости 
        } else
        {
            // комбинированный поворот
        }
    }
}
