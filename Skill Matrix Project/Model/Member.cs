namespace Skill_Matrix_Projekt.Model
{
    public class Member
    {
        public int Id
        {
            get;set;
        }
        public string Name
        {
            get;set;
        }
        public string LastName
        {
            get;set;
        }
        public string Job
        {
            get;set;
        }
        public List<Skill> Skills
        {
            get;set;
        }
    }
}