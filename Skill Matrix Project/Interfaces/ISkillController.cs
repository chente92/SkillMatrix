namespace Skill_Matrix_Projekt
{
    public interface ISkillController
    {
         void addNewSkill(Skill skill);
         void deleteSkill(int skillId);
         Skill getSkill(int skillId);
         List<Skill>getAllSkills();
    }
}