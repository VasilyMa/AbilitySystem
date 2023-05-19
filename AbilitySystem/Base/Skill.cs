using UnityEngine;

public class Skill : ScriptableObject, ISkill, ISkillModifier
{
    public string Name;
    public string Description;
    public int Damage;
    public int Area;
    public float Range;

    public virtual void ApplySkill(IModifier modifier)
    {
        modifier.ModifierSkill();
    }

    public virtual string Cast()
    {
        return "I am cast: ";
    }
}
