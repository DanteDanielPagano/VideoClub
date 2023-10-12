using MySql.Data.MySqlClient;
using VideoClub.BusinessRules.PersonalException;
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
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int actorId)
        {
            try
            {
                var result = await _context.Actors.FirstOrDefaultAsync(a => a.Id == actorId && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<List<Actor>> GetAllActors()
        {
            try
            {
                List<Actor> result = new List<Actor>();
                result = await _context.Actors.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
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

                throw new DBMySqlException(ex.Number, ex.Message);
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
