namespace CSharpProgrammingBasics._02SimpleOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class _05ProjectsCreation
    {
        internal static void Start()
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int hours = projectsCount * 3;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, hours, projectsCount);
        }
    }
}
