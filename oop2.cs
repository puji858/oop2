using system ;
using system.Collection.generic;
using system.Linq;
using system.Text;
using systen.threading.Tasks;

namespace latihaninheritance
{
    class program
    {
    static void main(string[] args)
        {
        person person = new person("mike",20);
        person.GetNameAndAge();

        Teacher teacher = new Teacher("thomas",35, "190302", "math");
        teacher.GetNameAndAge();

        student student = new student("sara", 19, "10506", "sara1234@amikom.ac.id");
        student.GetNameAndAge();

        console.readkey()
        ;
         }
    }
}

