using Skill_Matrix_Projekt.Model;

namespace Skill_Matrix_Projekt
{
    public interface IMemberController
    {
        void addNewMember(Member member);
        void deleteMember(int memberId);
        void changeName(int memberId,string name);
        void changeLastName(int memberId, string lastName);
        void changeJob(int memberId, string job);
        void addSkillToMember(int memberId,Skill skill);
        void changeSkillLevel(int memberId,int skillId, SkillLevel skillLevel);
        void deleteSkillOfMember(int memberId,int skillId);
        Member getMember(int memberId);
        List<Member> getAllMembers();
    }
}