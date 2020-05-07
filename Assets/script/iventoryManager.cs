using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iventoryManager : MonoBehaviour
{
    static iventoryManager instance;

    public iventory m_bag;
    public GameObject m_slot_grid;
    public slot m_slot_prefab;
    public Text m_info;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(this.gameObject);
        }
        instance = this;
    }

    public static void creatitem(item se_item)
    {
        slot newitem = Instantiate(instance.m_slot_prefab,instance.m_slot_grid.transform.position,Quaternion.identity);
        newitem.gameObject.transform.SetParent(instance.m_slot_grid.transform);
        newitem.m_slot_item = se_item;
        newitem.m_slot_image.sprite = se_item.m_image;
        newitem.m_slot_number.text = se_item.m_num.ToString();
    }
}
