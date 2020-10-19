using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeorgianGym.Data;
using GeorgianGym.Models;

namespace GeorgianGym.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Userss.Include(u => u.Membership).Include(u => u.Trainer);
            return View(await applicationDbContext.OrderBy(t =>t.name).ToListAsync());
        }
        public async Task<IActionResult> scheduleDetails(int? id)
        {
            // var schedule =await _context.Schedules.Include(u => u.ScheduleId).FirstOrDefaultAsync(m => m.UsersId == id);
            // var schedule = await _context.Schedules.FindAsync(id);
            // ViewData["userId"] = new SelectList(_context.Schedules, "UserId", "UserId", schedule.UsersId);
            var applicationDbContext = _context.Schedules.Include(s => s.Users);
            return View(await applicationDbContext.ToListAsync());
            
        }
        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Userss
                .Include(u => u.Membership)
                .Include(u => u.Trainer)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }
       
        // GET: Users/Create
        public IActionResult Create()
        {
            ViewData["MembershipId"] = new SelectList(_context.Memberships, "MembershipId", "MembershipId");
            ViewData["trainerName"] = new SelectList(_context.Trainers, "trainerName", "trainerName");
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,TrainerId,MembershipId,name,age,email,phoneNumber,address,gender")] Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembershipId"] = new SelectList(_context.Memberships, "MembershipId", "MembershipId", users.MembershipId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", users.TrainerId);
            ViewData["trainerName"] = new SelectList(_context.Trainers, "trainerName", "trainerName", users.Trainer.trainerName);
            return View(users);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Userss.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            ViewData["MembershipId"] = new SelectList(_context.Memberships, "MembershipId", "MembershipId", users.MembershipId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", users.TrainerId);
            return View(users);
        }
        // GET: Users/Schedule/5
        
        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,TrainerId,MembershipId,name,age,email,phoneNumber,address,gender")] Users users)
        {
            if (id != users.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembershipId"] = new SelectList(_context.Memberships, "MembershipId", "MembershipId", users.MembershipId);
            ViewData["TrainerId"] = new SelectList(_context.Trainers, "TrainerId", "TrainerId", users.TrainerId);
            return View(users);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Userss
                .Include(u => u.Membership)
                .Include(u => u.Trainer)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Userss.FindAsync(id);
            _context.Userss.Remove(users);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Userss.Any(e => e.UserId == id);
        }
    }
}
