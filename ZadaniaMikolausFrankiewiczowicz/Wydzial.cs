using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaMikolausFrankiewiczowicz
{
    using System;
    using System.Collections.Generic;

    class Wydzial
    {
        private List<Student> studenci = new List<Student>();

        public void DodajStudenta(Student student)
        {
            if (studenci.Contains(student))
            {
                Console.WriteLine("Nie można dodać studenta o tym samym loginie i haśle");
                return;
            }

            studenci.Add(student);
            student.ZmienHaslo(student.haslo, "noweHaslo");
            student.ZmienLogin(student.login, "nowyLogin");
        }

        public void WypiszStudentow()
        {
            Console.WriteLine("Studenci na wydziale:");
            foreach (Student student in studenci)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

}
