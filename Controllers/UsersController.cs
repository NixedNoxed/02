using LibraryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersDbContext _context;

        public UsersController(UsersDbContext context)
        {
            _context = context;
        }

        // Действие за регистрация на нов потребител
        [HttpPost]
        public IActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        // Действие за вход на потребител
        [HttpPost]
        public IActionResult Login(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (existingUser != null)
            {
                // Потребител вписан успешно
                // Можете да извършите допълнителни действия, като например пренасочване към друга страница
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Невалидно потребителско име или парола
                // Можете да извършите допълнителни действия, като например показване на съобщение за грешка
                return RedirectToAction(nameof(Login));
            }
        }
    }
}
