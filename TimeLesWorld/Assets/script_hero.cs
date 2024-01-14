using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_hero : MonoBehaviour
{

    [SerializeField]
    private float _speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, vertical, 0) * _speed * Time.deltaTime);

    }
}
