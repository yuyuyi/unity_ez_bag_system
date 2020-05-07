using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new iventory", menuName = "inventoryscript/new iventory")]
public class iventory : ScriptableObject
{
    public List<item> itmelist= new List<item>();

}
