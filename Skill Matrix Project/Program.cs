using Skill_Matrix_Projekt;
using Skill_Matrix_Projekt.Model;

class Programm
{
    static void Main(string[] args)
    {
        MemberController mockUpMemberController = new MemberController();
        SkillController mockUpSkillController = new SkillController();

        IMemberController memberController = mockUpMemberController;
        ISkillController skillController = mockUpSkillController;

        Console.WriteLine("Member in List: " + memberController.getAllMembers().Count());
        
        //test create member
        createMembers(memberController);
        Console.WriteLine("Member in List after 3 Add: " + memberController.getAllMembers().Count());
        
        //test delete member
        memberController.deleteMember(0);
        Console.WriteLine("Member in List after 1 Delete: " + memberController.getAllMembers().Count());

        //test change member
        Member tempMember  = memberController.getMember(1);
        Console.WriteLine("Member 1 before change: " + tempMember.Name + " " + tempMember.LastName + " "+ tempMember.Job);
        changeMember(memberController);
        tempMember = memberController.getMember(1);
        Console.WriteLine("Member 1 after change: " + tempMember.Name + " " + tempMember.LastName + " " + tempMember.Job);

        //test create skills
        Console.WriteLine("Skills in List: " + skillController.getAllSkills().Count());
        createSkills(skillController);
        Console.WriteLine("Skills in List after 4 Add: " + skillController.getAllSkills().Count());

        //test delete skill
        skillController.deleteSkill(3);
        Console.WriteLine("Skills in List afer one Delete: " + skillController.getAllSkills().Count());

        //add skill to Member and change it
        memberController.addSkillToMember(1, skillController.getSkill(0));
        memberController.addSkillToMember(1, skillController.getSkill(1));
        memberController.addSkillToMember(1, skillController.getSkill(2));
        Console.WriteLine("Skills of Member 1 after 3 Skills added: " + memberController.getMember(1).Skills.Count());
        memberController.changeSkillLevel(1, 0, SkillLevel.A1);
        Console.WriteLine("Skilllevel from Member 1 of " + memberController.getMember(1).Skills[0].Name + " was changed to " + memberController.getMember(1).Skills[0].SkillLevel);

        //delete skill from Member
        memberController.deleteSkillOfMember(1, 1);
        Console.WriteLine("Skills of Member 1 after 1 skill deleted: " + memberController.getMember(1).Skills.Count());

        
    }

    static void createSkills(ISkillController skillController)
    {
        Skill skill = new Skill();
        skill.Id = 0;
        skill.Name = "English";
        skill.IsLanguage = true;
        skill.category = SkillCategory.Language;
        skillController.addNewSkill(skill);
        
        skill = new Skill();
        skill.Id = 1;
        skill.Name = "C#";
        skill.IsLanguage = false;
        skill.category = SkillCategory.ProgrammingLanguage;
        skillController.addNewSkill(skill);
        
        skill = new Skill();
        skill.Id = 2;
        skill.Name = "Reder";
        skill.IsLanguage = false;
        skill.category = SkillCategory.Softskill;
        skillController.addNewSkill(skill);

        skill = new Skill();
        skill.Id = 3;
        skill.Name = "Reder";
        skill.IsLanguage = true;
        skill.category = SkillCategory.Softskill;
        skillController.addNewSkill(skill);
    }
    static void createMembers(IMemberController memberController)
    {
        Member member = new Member();
        member.Name = "sascha";
        member.Id = 0;
        member.Skills = null;
        member.LastName = "Last Name";
        member.Job = "Arbeitslos";
        member.Skills = new List<Skill>();
        memberController.addNewMember(member);

        member = new Member();
        member.Name = "Peter";
        member.Id = 1;
        member.Skills = null;
        member.LastName = "LastName";
        member.Job = "Arbeitslos";
        member.Skills = new List<Skill>();
        memberController.addNewMember(member);

        member = new Member();
        member.Name = "Hans";
        member.Id = 2;
        member.Skills = null;
        member.LastName = "Last Name";
        member.Job = "Arbeitslos";
        member.Skills = new List<Skill>();
        memberController.addNewMember(member);

        return;
    }

    static void changeMember(IMemberController memberController)
    {
        memberController.changeJob(1, "developer");
        memberController.changeLastName(1, "Müller");
        memberController.changeName(1, "Hubertus");
    }

    
}