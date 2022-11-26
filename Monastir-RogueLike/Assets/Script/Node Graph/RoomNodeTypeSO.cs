using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="RoomNodeType_", menuName = "Scriptable Object/Dungeon/Room Node Type")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string RoomNodeTypeName;
    #region Header
    [Header("Only flag the RoomnodeTypes that should be visible in editor")]
    #endregion
    public bool DisplayInNodeGraphEditor=true;
    #region Header
    [Header("One Type should be a corridor")]
    #endregion
    public bool isCorridor;
    #region Header
    [Header("One Type should be a corridorNS")]
    #endregion
    public bool isCorridorNS;
    #region Header
    [Header("One Type should be a corridorEW")]
    #endregion
    public bool isCorridorEW;
    #region Header
    [Header("One Type should be an entrance")]
    #endregion
    public bool isEntrance;
    #region Header
    [Header("One Type should be a Boos Room")]
    #endregion
    public bool isBossRoom;
    #region Header
    [Header("One Type should be None (unassigned)")]
    #endregion
    public bool isNone;

}
