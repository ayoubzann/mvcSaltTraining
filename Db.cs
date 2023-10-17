using mvcSaltTraining.Models;

namespace mvcSaltTraining;
public class Db
{
    public Db()
    {
         Developers = new List<Developer>()
        {
            new Developer() {ID = 0, Name = "Lauren Holmen", Email = "bambina@hotmail.com"},
            new Developer() {ID = 1, Name = "Ayoub Zannachi", Email = "ayoubzann@gmail.com"},
            new Developer() {ID = 2, Name = "Carina Borras Ruud", Email = "yudenia2009@hotmail.com"},
        };
    }
    public List<Developer> Developers {get; set;}
}