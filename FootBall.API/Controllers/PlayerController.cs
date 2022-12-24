using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootBall.API.Controllers
{
    using FootBall.API.Context;
    using FootBall.API.Models;

    using Microsoft.EntityFrameworkCore;

    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private PlayerContext db;

        public PlayerController(PlayerContext db)
        {
            this.db = db;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Player>>> GetAll()
        {
            return await this.db.Player.ToListAsync();
        }

        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<Player>> GetById(int id)
        {
            Player player = await this.db.Player.FirstOrDefaultAsync(x => x.Id == id);

            if (player == null)
                return NotFound();

            return new ObjectResult(player);
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<User>> Create(Player player)
        {
            if (player == null)
                return this.BadRequest();

            db.Player.Add(player);

            await this.db.SaveChangesAsync();

            return Ok(player);
        }

        [HttpPut("[action]")]
        public async Task<ActionResult<Player>> Update(Player player)
        {
            if (player == null)
                return this.BadRequest();

            if (!db.Player.Any(x => x.Id == player.Id))
                return this.NotFound();

            db.Player.Update(player);
            await db.SaveChangesAsync();

            return Ok(player);
        }

        [HttpDelete("[action]")]
        public async Task<ActionResult<Player>> Delete(int id)
        {
            Player player = await this.db.Player.FirstOrDefaultAsync(x => x.Id == id);

            if (id < 0)
                return NotFound();

            db.Player.Remove(player);
            await db.SaveChangesAsync();
            return Ok(player);
        }
    }
}

