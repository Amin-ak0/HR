using System.Diagnostics.CodeAnalysis;

namespace HR
{
    public class Actions
    {
        public void Members(List<Hr> employee)
        {
           
            employee.Add(new Hr(1, "ali", "akbari", 123549, 1394 / 03 / 14,true));
            
        }
        public void Recruitment(List<Hr> employee)
        {
            employee.Add(new Hr(1, "ali", "akbari", 123549, 1394 / 03 / 14,true));
        }

        public void firedup(List<Hr> employee)
        {
            if (employee.Count > 6 == false)
            {
                employee.RemoveAt(0);
            }
        }

    }
}
