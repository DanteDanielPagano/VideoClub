using MySql.Data.MySqlClient;
using VideoClub.Repository.PersonalException;

namespace VideoClub.Repository.Repositories
{
    public class ActorRepository : IActorRepository
    {
        readonly VideoClubContext _context;

        public ActorRepository(VideoClubContext context)
        {
            _context = context;
        }

        public async Task Create(Actor actor)
        {
            try
            {
                await _context.AddAsync(actor);
            }
            catch (MySqlException ex)
            {

                throw new DBException(ex.Number, ex.Message);
            }
        }

        public Task Delete(int actorId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Actor>> GetAllActors()
        {
            try
            {
                List<Actor> result = new List<Actor>();
                result = await _context.Actors.ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBException(ex.Number, ex.Message);
            }

        }

        public async Task<Actor> GetById(int actorId)
        {
            try
            {
                Actor result = new Actor();
                result = await _context.Actors.FindAsync(actorId);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBException(ex.Number, ex.Message);
            }
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(Actor actor)
        {
            throw new NotImplementedException();
        }
    }
}
