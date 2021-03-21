using System.Collections.Generic;
using DapperDoodle;
using TestProject.Models;

namespace TestProject.Queries
{
    public class SelectAPerson : Query<List<Person>>
    {
        private readonly int _id;

        public SelectAPerson(int id)
        {
            _id = id;
        }
        public override void Execute()
        {
            Result = BuildSelect<Person>("where id = @Id", new { Id = _id });
        }
    }
}