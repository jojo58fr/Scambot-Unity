using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class FriendScriptableObject : ScriptableObject
{
    public string characterName;
    public string pseudo;
    public int age;

    public Sprite profil;

    public Flowchart flowchart;

}
