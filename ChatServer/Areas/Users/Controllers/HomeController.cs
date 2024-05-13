using ChatServer.Areas.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatServer.Areas.Users.Controllers
{
    [Area("Users")]
    public class HomeController : Controller
    {
        List<ClassUsers> users = new List<ClassUsers>
        {
            new() { Id = Guid.NewGuid().ToString(), Username = "dekey111", Login = "dekey111", Password = "1" },
            new() { Id = Guid.NewGuid().ToString(), Username = "Artem", Login = "Artem", Password = "2" },
            new() { Id = Guid.NewGuid().ToString(), Username = "Denis", Login = "Denis", Password = "3" }
        };

        public IActionResult Index()
        {
            return View(users);
        }


//        app.MapGet("/api/users/{id}", (string id) =>
//        {
//            // получаем пользователя по id
//            ClassUsers? user = users.FirstOrDefault(x => x.Id == id);
//            // если не найден, отправляем статусный код и сообщение об ошибке
//            if (user == null) return Results.NotFound(new { message = "Пользователь не найден" });

//            // если пользователь найден, отправляем его
//            return Results.Json(user);
//        });

//app.MapDelete("/api/users/{id}", (string id) =>
//{
//    // получаем пользователя по id
//    ClassUsers? user = users.FirstOrDefault(x => x.Id == id);

//    // если не найден, отправляем статусный код и сообщение об ошибке
//    if (user == null) return Results.NotFound(new { message = "Пользователь не найден" });

//    // если пользователь найден, удаляем его
//    users.Remove(user);
//    return Results.Json(user);
//});

//app.MapPost("/api/users", (ClassUsers user) =>
//{

//    // устанавливаем id для нового пользователя
//    user.Id = Guid.NewGuid().ToString();
//    // добавляем пользователя в список
//    users.Add(user);
//    return user;
//});

//app.MapPut("/api/users", (ClassUsers userData) =>
//{

//    // получаем пользователя по id
//    var user = users.FirstOrDefault(u => u.Id == userData.Id);
//    // если не найден, отправляем статусный код и сообщение об ошибке
//    if (user == null) return Results.NotFound(new { message = "Пользователь не найден" });
//    // если пользователь найден, изменяем его данные и отправляем обратно клиенту

//    user.Username = userData.Username;
//    user.Login = userData.Login;
//    user.Password = userData.Password;
//    return Results.Json(user);
//});

    }
}
