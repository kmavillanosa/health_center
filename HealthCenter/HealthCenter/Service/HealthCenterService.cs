using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCenter
{
    public interface IHealthCenterService
    {
        Task<Account> Login(string username, string password);

        Task<int> CreateAccountLog(AccountLogs accountLog);
        Task<bool> SetLogoutTime(int LogId, DateTime Time);

        Task<IEnumerable<CategoryPerEvent>> GetCategoriesPerEvent();

        Task<string> GetPassword(string userName);


        Task<IEnumerable<Account>> GetAccounts();
        Task<int> CreateAccount(Account account);
        Task<bool> ModifyAccount(Account account);
        Task<bool> RemoveAccount(Account account);


        Task<IEnumerable<Person>> GetPeopleList();
        Task<int> CreateProfile(Person person);
        Task<bool> ModifyProfile(Person person);

        Task<IEnumerable<PersonCategory>> GetPersonCategories();
        Task<int> CreateCategory(PersonCategory personCategory);
        Task<bool> ModifyCategory(PersonCategory personCategory);


        Task<IEnumerable<PersonEvents>> LoadEvents();
        Task<int> CreateEvent(PersonEvents events);
        Task<bool> ModifyEvent(PersonEvents events);

        Task<int> CreateEventLogs(EventLogs logs);
        Task<bool> RemoveEventLogs(EventLogs logs);

        Task<int> CreateMedicalConsultation(Consultation consultation);
        Task<bool> ModifyMedicalConsultation(Consultation consultation);

        Task<IEnumerable<Ailments>> GetAilments();
         Task<int> CreateAilment(Ailments ailment);
        Task<bool> ModifyAilment(Ailments ailment);

    }

    public class HealthCenterService : IHealthCenterService
    {
        private readonly IDbConnection DataConnection;


    

        public HealthCenterService(string connectionString)
        {
            DataConnection = new MySqlConnection(connectionString);
        }


        public async Task<string> GetPassword(string userName)
        {
            try
            {
                var dd = await DataConnection.QuerySingleAsync<string>(@"select password from useraccount where username = @uname", new { @uname = userName });
                return dd == null ? "No Account" : dd;
            }
            catch
            {
                return "No Account";
            }
        }

        public async Task<int> CreateAccount(Account account)
        {
            var data = await DataConnection.InsertAsync(account);
            return data;
        }

        public async Task<int> CreateAccountLog(AccountLogs accountLog)
        {
            var data = await DataConnection.InsertAsync(accountLog);
            return data;
        }

        public async Task<int> CreateAilment(Ailments ailment)
        {
            var data = await DataConnection.InsertAsync(ailment);
            return data;
        }

        public async Task<int> CreateCategory(PersonCategory personCategory)
        {
            var data = await DataConnection.InsertAsync(personCategory);
            return data;
        }

        public async Task<int> CreateEvent(PersonEvents events)
        {
            var data = await DataConnection.InsertAsync(events);
            return data;
        }

        public async Task<int> CreateEventLogs(EventLogs logs)
        {
            var data = await DataConnection.InsertAsync(logs);
            return data;
        }

        public async Task<int> CreateMedicalConsultation(Consultation consultation)
        {
            var data = await DataConnection.InsertAsync(consultation);
            return data;
        }

        public async Task<int> CreateProfile(Person person)
        {
            var data = await DataConnection.InsertAsync(person);
            return data;
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            var data = await DataConnection.GetAllAsync<Account>();
            foreach(var item in data)
            {
                item.Logs = await DataConnection.QueryAsync<AccountLogs>("SELECT * FROM accountlogs where AccountId = @id order by id desc limit 50", new { @id = item.Id });
            }
            return data;
        }

        public async Task<IEnumerable<Ailments>> GetAilments()
        {
            using (DataConnection)
            {
                var ailment = await DataConnection.GetAllAsync<Ailments>();
                return ailment;
            }
        }

        public async Task<IEnumerable<CategoryPerEvent>> GetCategoriesPerEvent()
        {
            using (DataConnection)
            {
                var data = await DataConnection.QueryAsync<CategoryPerEvent>(@"SELECT 
    E.`Title`, ifnull( cat.`Value`, 'No participant') as Category, count(cat.id) as `Count`
FROM
    events E
        LEFT JOIN
    eventlogs EL ON E.`Id` = el.`Event`
        LEFT JOIN
    person p ON el.`PersonId` = p.`Id`
        LEFT JOIN
    personcategory cat ON p.`CategoryId` = cat.`Id`
GROUP BY cat.Id
order by count asc");
                return data;
            }
        }

      
        public async Task<IEnumerable<Person>> GetPeopleList()
        {
            using (DataConnection)
            {
                var people = await DataConnection.GetAllAsync<Person>();

                foreach (var item in people)
                {
                    item.Category = await DataConnection.GetAsync<PersonCategory>(item.CategoryId);
                    item.Consultations = await DataConnection
                        .QueryAsync<Consultation>("SELECT * FROM medical_consultation where personId = @personId",
                        new { @personId = item.Id });

                    item.EventConsultations = await DataConnection
                        .QueryAsync<EventConsultations>(@"SELECT 
    e.`title` as `Event`,
    ail.`name` as `Ailment`,
    mc.BloodPressure,
    mc.Weight,
    mc.Height,
    mc.ExpectedChildGender,
    mc.PregnancyDueDate,
    mc.Diagnosis,
    mc.Remarks,
    mc.LastModified AS `ConsultationDate`
FROM
    person p
        LEFT JOIN
    eventlogs el ON p.`id` = el.personId
        LEFT JOIN
    `events` e ON e.id = el.`Event`
        LEFT JOIN
    medical_consultation mc ON mc.id = el.consultationId
        LEFT JOIN
    `ailments` ail ON ail.id = mc.AilmentGroupId
    where p.id = @pId", new { @pId = item.Id});


                    foreach (var consultation in item.Consultations)
                    {
                        consultation.Ailment = await DataConnection.GetAsync<Ailments>(consultation.AilmentGroupId);
                    }
                }
                return people;
            }
           

        }

        public async Task<IEnumerable<PersonCategory>> GetPersonCategories()
        {
            return await DataConnection.GetAllAsync<PersonCategory>();
        }

        public async Task<IEnumerable<PersonEvents>> LoadEvents()
        {
            var events = await DataConnection.GetAllAsync<PersonEvents>();
            foreach(var ev in events)
            {
                ev.Logs = await DataConnection
                    .QueryAsync<EventLogs>("SELECT * FROM eventlogs e where e.`event` = @eventId", 
                    new { @eventId = ev.Id });

                foreach(var log in ev.Logs)
                {
                    log.Person = await DataConnection.GetAsync<Person>(log.PersonId);
                    log.Person.Category = await DataConnection.GetAsync<PersonCategory>(log.Person.CategoryId);
                    log.Consultation = await DataConnection.GetAsync<Consultation>(log.ConsultationId);

                    //log.Person.Consultations = await DataConnection
                    //    .QueryAsync<Consultation>("SELECT * FROM medical_consultation where personId = @personId",
                    //    new { @personId = log.Person.Id });
                }

            }
            return events;
        }

        public async Task<Account> Login(string Username, string Password)
        {
            using (DataConnection)
            {
                var data = await DataConnection
                .QuerySingleOrDefaultAsync<Account>
                ("SELECT * FROM useraccount where binary `username` = @username and binary `password` = @pw",
                new { @username = Username, @pw = Password });


                string Remarks = string.Empty;
                bool Allow = false;

                if (data != null)
                {

                    Remarks = "Access granted";
                    Allow = true;

                    if (data.AccountStatus == AccountStatus.Inactive)
                    {
                        Allow = false;
                        Remarks = "Account inactive, please contact administrator";
                    }
                }
                else
                {
                    Allow = false;
                    Remarks = "Access Denied";
                }


                return data;
            }
        }

        public async Task<bool> ModifyAccount(Account account)
        {
            var data = await DataConnection.UpdateAsync(account);
            return data;
        }

        public async Task<bool> ModifyAilment(Ailments ailment)
        {
            var data = await DataConnection.UpdateAsync(ailment);
            return data;
        }

        public async Task<bool> ModifyCategory(PersonCategory personCategory)
        {
            var data = await DataConnection.UpdateAsync(personCategory);
            return data;
        }

        public async Task<bool> ModifyEvent(PersonEvents events)
        {
            var data = await DataConnection.UpdateAsync(events);
            return data;
        }

        public async Task<bool> ModifyMedicalConsultation(Consultation consultation)
        {
            var data = await DataConnection.UpdateAsync(consultation);
            return data;
        }

        public async Task<bool> ModifyProfile(Person person)
        {
            var data = await DataConnection.UpdateAsync(person);
            return data;
        }

        public async Task<bool> RemoveAccount(Account account)
        {
            var data = await DataConnection.UpdateAsync(account);
            return data;
        }

        public async Task<bool> RemoveEventLogs(EventLogs logs)
        {
            var data = await DataConnection.UpdateAsync(logs);
            return data;
        }

        public async Task<bool> SetLogoutTime(int LogId, DateTime Time)
        {
            try
            {
                var data = await DataConnection.ExecuteAsync(@"UPDATE `accountlogs` SET `TimeOut` = @timeout WHERE Id = @Id", new { @timeout = Time, @id = LogId });
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
