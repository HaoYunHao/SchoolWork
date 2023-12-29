using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour
{
    public Animator m_Animator ;
    
    // Start is called before the first frame update
    void Start()
    {
      
        m_Animator =GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
  
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * 3, 0);
            transform.Translate(0, 0, 0.05f);
            //动画控制
            m_Animator.SetBool("isWalk",true);
        }
        else
        {
            m_Animator.SetBool("isWalk", false);
        }


        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * 3, 0);
            transform.Translate(0, 0, 0.1f);
            //动画控制
            m_Animator.SetBool("isRun", true);
        }
        else
        {
            m_Animator.SetBool("isRun", false);
        }

        if (Input.GetMouseButton(2))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * 3, 0);
        }
    }
}
