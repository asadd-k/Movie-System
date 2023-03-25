using Movie_System.Models;

namespace Movie_System.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDb _context;

        public ActorsService(AppDb context)
        {
            _context=context;
        }

        public void add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor Getbyid(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newactor)
        {
            throw new NotImplementedException();
        }
    }
}
