using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minMap : MonoBehaviour
{
    public Transform hero;
    private void LateUpdate()
    {
        Vector3 newpostion = hero.position;
        newpostion.y = transform.position.y;
        transform.position = newpostion;
        transform.rotation = Quaternion.Euler(90f,hero.eulerAngles.y,0f);
    }

}
