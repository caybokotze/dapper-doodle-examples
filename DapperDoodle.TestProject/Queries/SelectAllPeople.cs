using System.Collections.Generic;
using DapperDoodle;
using TestProject.Models;

namespace TestProject.Queries
{
    public class SelectAllPeople : Query<List<Person>>
    {
        public override void Execute()
        {

        }
    }
}