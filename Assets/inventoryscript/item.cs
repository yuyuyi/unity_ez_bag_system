using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new fil",menuName = "inventoryscript/new fil")]
public class item : ScriptableObject
{
    public string m_name;
    public Sprite m_image;
    public int m_num;

    [TextArea]
    public string m_info;
}
