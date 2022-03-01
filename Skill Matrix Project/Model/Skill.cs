public class Skill{
    public int Id
    {
        get;set;
    }
    public string Name
    {
        get;set;
    }
    public bool IsLanguage
    {
        get;set;
    }
    public SkillLevel SkillLevel
    {get;set;}

    public SkillCategory category
    {get;set;}
    
}

    public enum SkillCategory{
        ProgrammingLanguage,
        Language,
        Softskill
    }

    public enum SkillLevel 
    {
        Beginner = 100,
        Intermediate = 200,
        Expert = 300,
        Profi = 400,
        A1 = 0,
        B1 = 1,
        C1 = 2
    }