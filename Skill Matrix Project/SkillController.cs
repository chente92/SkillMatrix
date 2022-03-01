namespace Skill_Matrix_Projekt
{
    public class SkillController : ISkillController
    {
        List<Skill> skills = new List<Skill>();

        public void addNewSkill(Skill skill){
            skills.Add(skill);
        }
        public void deleteSkill(int skillId){
            foreach(Skill skill in skills){
                if(skill.Id == skillId){
                    skills.Remove(skill);
                    return;
                }
            }
        }
        public Skill getSkill(int skillId){
            foreach(Skill skill in skills){
                if(skill.Id == skillId){
                    return skill;
                }
            }
            return null;
        }
        public List<Skill>getAllSkills(){
            return skills;
        }
    }
}