using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Движение объекта в зад и вперед по прямой 
public class BackAndForth : MonoBehaviour
{

    public float speed = 3.0f;
    public float maxZ = 16.0f;
    public float minZ = -16.0f; // объект движется между этими точками 

    private int _direction = 1;

    void Update()
    {
        transform.Translate(0, 0, _direction * speed * Time.deltaTime);

        bool bounced = false;
        if(transform.position.z > maxZ || transform.position.z < minZ)
        {
            _direction = -_direction;
            bounced = true; // меняем направление на противоположное 
        }
        if(bounced)
        {
            transform.Translate(0, 0, _direction * speed * Time.deltaTime); // делаем доп. движение если объект поменял направление 
        }
    }
}
