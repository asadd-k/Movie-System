using Movie_System.Models;

namespace Movie_System.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        
        Actor Getbyid(int id); 

        void add(Actor actor);

        Actor Update(int id, Actor newactor);

        void Delete(int id);
    }
}
