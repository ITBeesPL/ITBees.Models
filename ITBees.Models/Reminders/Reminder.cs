using System;
using ITBees.Models.Companies;
using ITBees.Models.Users;

namespace ITBees.Models.Reminders
{
    public class Reminder
    {
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public DateTime? RemindDate { get; set; }
        public string TaskToDo { get; set; }
        public string TaskResult { get; set; }
        public UserAccount CreatedBy { get; set; }
        public Guid CreatedByGuid { get; set; }
        public bool IsActive { get; set; }
        public UserAccount FinishedBy { get; set; }
        public Guid? FinishedByGuid { get; set; }
        public Company Company { get; set; }
        public Guid CompanyGuid { get; set; }
        public string ReminderType { get; set; }
    }
}