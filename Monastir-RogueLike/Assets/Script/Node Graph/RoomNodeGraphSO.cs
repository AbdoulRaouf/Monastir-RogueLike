using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="RoomNodeGraph", menuName ="Scriptable Object/Dungeon/Room Node Graph")]
public class RoomNodeGraphSO : ScriptableObject
{
    [HideInInspector] public RoomNodeTypeListSO RoomNodeTypeList;
    [HideInInspector] public List<RoomNodeSO> RoomNodeList= new List<RoomNodeSO>();
    [HideInInspector] public Dictionary<string, RoomNodeSO> RoomNodeDictionairy=new Dictionary<string, RoomNodeSO>();

}
