public class SkillProvider : ISkillProvider
{
    public void CastSkill(ISkill skill)
    {
        skill.Cast();
    }
}
