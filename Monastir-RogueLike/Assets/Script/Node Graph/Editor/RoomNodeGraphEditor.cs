using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RoomNodeGraphEditor : EditorWindow
{
    private GUIStyle _roomNodeStyle;
    private const float _nodeWigh = 160f;
    private const float _nodeHeight = 75f;
    private const int _nodePadding = 25;
    private const int _nodeBorder = 12;
    [MenuItem(("Room Node Graph Editor"), menuItem= "Window/Dungeon Editor/Room Node Graph Editor")]//pour que ca soit accesible a partir du menu Window de l'editor
    private static void OpenWidow()//elle doit etre Statique pour qu'on puisse l'appeller à partir de l'editor
    {
        GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");//permer d'afficher la fenetre meme
    }

    private void OnEnable()
    {
        _roomNodeStyle = new GUIStyle();
        _roomNodeStyle.normal.background = EditorGUIUtility.Load("node1") as Texture2D;
        _roomNodeStyle.normal.textColor = Color.white;
        _roomNodeStyle.padding = new RectOffset(_nodePadding, _nodePadding, _nodePadding, _nodePadding);
        _roomNodeStyle.border= new RectOffset(_nodeBorder,_nodeBorder, _nodeBorder, _nodeBorder);
    }
    private void OnGUI()//permettre de dessiner, mettre des element dans notre fenetre
    {
        GUILayout.BeginArea(new Rect(new Vector2(100f,100f),new Vector2(_nodeWigh, _nodeHeight)), _roomNodeStyle);
        EditorGUILayout.LabelField("node1");
        GUILayout.EndArea();//doit etre mis sinon on aura une erreur

        GUILayout.BeginArea(new Rect(new Vector2(300f, 300f), new Vector2(_nodeWigh, _nodeHeight)), _roomNodeStyle);
        GUILayout.Label("node 3");
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(new Vector2(200f, 200f), new Vector2(_nodeWigh, _nodeHeight)), _roomNodeStyle);
        GUILayout.Label("node 2");
        GUILayout.EndArea();
    }
}
