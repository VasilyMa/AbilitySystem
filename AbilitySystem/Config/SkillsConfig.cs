using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Skill Config", menuName = "Skills/Config", order = 0)]
public class SkillsConfig : ScriptableObject
{
    public List<Skill> skills = new List<Skill>();

}
