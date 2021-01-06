using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            m_Animator.SetTrigger("shoot");
            Debug.Log("Fire Animation");
        }
    }
}
