using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemMain : MonoBehaviour
{
    public item m_item_name;
    public iventory m_player_bag;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            addnewitem();
            Destroy(this.gameObject);
        }
    }

    void addnewitem()
    {
        if(!m_player_bag.itmelist.Contains(m_item_name))
        {
            m_player_bag.itmelist.Add(m_item_name);
            iventoryManager.creatitem(m_item_name);
        }
        else
        {
            m_item_name.m_num++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
