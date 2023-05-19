using UnityEngine;

[CreateAssetMenu(fileName = "FireBall", menuName = "Skills/FireBall", order = 1)]
public class ActionSkill : Skill
{
    public Modifier[] Modifiers;
    public override string Cast()
    {
        for (int i = 0; i < Modifiers.Length; i++)
        {
            ApplySkill(Modifiers[i]);
        }
        Debug.Log($"{base.Cast()} {name}");
        return $"{base.Cast()} {name}";
    }
    public override void ApplySkill(IModifier modifier)
    {
        base.ApplySkill(modifier);
    }
}
