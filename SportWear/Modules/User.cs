//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportWear.Modules
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int empId { get; set; }
        public int roleId { get; set; }
        public int entTypeId { get; set; }
        public int sexId { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string phoneNum { get; set; }
        public int pasSeries { get; set; }
        public int pasNum { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public System.DateTime lastSeen { get; set; }
    
        public virtual entType entType { get; set; }
        public virtual role role { get; set; }
        public virtual sex sex { get; set; }
    }
}