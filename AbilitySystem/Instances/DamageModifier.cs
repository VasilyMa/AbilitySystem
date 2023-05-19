using UnityEngine;
[CreateAssetMenu(fileName = "DamageModifier", menuName = "Modifiers/Damage")]
public class DamageModifier : Modifier
{
    public int Amount;
    public override void ModifierSkill()
    {
        Debug.Log($"Damage increasess by {Amount}");
    }
}
