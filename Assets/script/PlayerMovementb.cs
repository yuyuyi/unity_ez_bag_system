using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementb : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("基本参数")]
    Transform m_transform;
    float m_transform_localScale_magnification = 1.0f;//缩放参数，用于移动
    public GameObject myBag;//背包
    private float bagTime = 0.5f; //背包每0.5秒可以切换一次状态,不设置的话会导致一直按b可以看到背包闪烁

    [Header("移动参数")]
    float m_speed = 5.0f;

    [Header("状态参数")]
    bool m_bag_is_open = false;//判断背包打开状态
    

    void Start()
    {
        m_transform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        EzMove();
        OpenBag();
    }

    private void EzMove()
    {
        float movev = 0;
        float moveh = 0;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movev += m_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movev -= m_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveh += m_speed * Time.deltaTime;
            if (m_transform.localScale.x > 0) m_transform.localScale = new Vector3(-m_transform_localScale_magnification * m_transform.localScale.x, m_transform.localScale.y, 1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveh -= m_speed * Time.deltaTime;
            if (m_transform.localScale.x < 0) m_transform.localScale = new Vector3(-m_transform_localScale_magnification * m_transform.localScale.x, m_transform.localScale.y, 1);
        }
        this.transform.Translate(new Vector2(moveh, movev));
    }
    
    private void OpenBag()
    {
        bagTime -= Time.deltaTime;
        if(Input.GetKey(KeyCode.B) && bagTime<0)
        {
            bagTime = 0.5f;
            m_bag_is_open = !m_bag_is_open;//切换状态

            myBag.SetActive(m_bag_is_open);
        }
    }
    //按下b可以打开或关闭背包
}
