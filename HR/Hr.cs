using Microsoft.VisualBasic;

namespace HR
{
    public class Hr
    {
        private int Id { get; set; }
        private string Fname { get; set; }
        private string Lname { get; set; }
        private uint Accountnumber { get; set; }
        private int Hiringday { get; set; }
        private bool IsHiring { get; set; }

        public Hr(int id, string fname, string lname, uint accountnumber, int hiringday, bool ishiring)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Accountnumber = accountnumber;
            Hiringday = hiringday;
            IsHiring = ishiring;
        }

    }

}
