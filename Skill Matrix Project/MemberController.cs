using Skill_Matrix_Projekt.Model;


namespace Skill_Matrix_Projekt
{
    public class MemberController : IMemberController
    {
        List<Member> members = new List<Member>();

        public void addNewMember(Member member){
            members.Add(member);
        }
        public void deleteMember(int memberId){
            foreach(Member member in members){
                if(member.Id == memberId){
                    members.Remove(member);
                    return;
                }
            }
        }
        public void changeName(int memberId,string name){
            foreach(Member member in members){
                if(member.Id == memberId){
                    member.Name = name;
                    return;
                }
            }
        }
        public void changeLastName(int memberId, string lastName){
            foreach(Member member in members){
                if(member.Id == memberId){
                    member.LastName = lastName;
                    return;
                }
            }
        }
        public void changeJob(int memberId, string job){
            foreach(Member member in members){
                if(member.Id == memberId){
                    member.Job = job;
                    return;
                }
            }
        }
        public void addSkillToMember(int memberId,Skill skill){
            foreach(Member member in members){
                if(member.Id == memberId){
                    member.Skills.Add(skill);
                    return;
                }
            }
        }
        public void changeSkillLevel(int memberId,int skillId, SkillLevel skillLevel){
            foreach(Member member in members){
                if(member.Id == memberId){
                    foreach(Skill skill in member.Skills){
                        if(skill.Id == skillId){
                            skill.SkillLevel = skillLevel;
                            return;
                        }
                    }
                }
            }
        }

        public void deleteSkillOfMember(int memberId,int skillId){
            foreach(Member member in members){
                if(member.Id == memberId){
                    foreach(Skill skill in member.Skills){
                        if(skill.Id == skillId){
                            member.Skills.Remove(skill);
                            return;
                        }
                    }
                }
            }
        }
        public Member getMember(int memberId){
            foreach(Member member in members){
                if(member.Id == memberId){
                    return member;
                }
            }
            return null;
        }
        public List<Member> getAllMembers(){
            return members;
        }
    }
}