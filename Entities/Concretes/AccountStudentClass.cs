using Core.Entities;

namespace Entities.Concretes
{
    public class AccountStudentClass : Entity<int>
    {
        public int AccountId { get; set; }
        public int StudentClassId { get; set; }
        public Account? Account { get; set; }    
        public StudentClass? StudentClass { get; set; }

    }

}
