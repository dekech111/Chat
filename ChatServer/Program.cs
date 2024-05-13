using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json;


//List<ClassUsers> users = new List<ClassUsers>
//{
//    new() { Id = Guid.NewGuid().ToString(), Username = "dekey111", Login = "dekey111", Password = "1" },
//    new() { Id = Guid.NewGuid().ToString(), Username = "Artem", Login = "Artem", Password = "2" },
//    new() { Id = Guid.NewGuid().ToString(), Username = "Denis", Login = "Denis", Password = "3" }
//};


//var builder = WebApplication.CreateBuilder();


//var app = builder.Build();

//app.UseDefaultFiles();
//app.UseStaticFiles();

//app.MapGet("/api/users", () => users);

//app.MapGet("/api/users/{id}", (string id) =>
//{
//    // получаем пользовател€ по id
//    ClassUsers? user = users.FirstOrDefault(x => x.Id == id);
//    // если не найден, отправл€ем статусный код и сообщение об ошибке
//    if (user == null) return Results.NotFound(new { message = "ѕользователь не найден" });

//    // если пользователь найден, отправл€ем его
//    return Results.Json(user);
//});

//app.MapDelete("/api/users/{id}", (string id) =>
//{
//    // получаем пользовател€ по id
//    ClassUsers? user = users.FirstOrDefault(x => x.Id == id);

//    // если не найден, отправл€ем статусный код и сообщение об ошибке
//    if (user == null) return Results.NotFound(new { message = "ѕользователь не найден" });

//    // если пользователь найден, удал€ем его
//    users.Remove(user);
//    return Results.Json(user);
//});

//app.MapPost("/api/users", (ClassUsers user) =>
//{

//    // устанавливаем id дл€ нового пользовател€
//    user.Id = Guid.NewGuid().ToString();
//    // добавл€ем пользовател€ в список
//    users.Add(user);
//    return user;
//});

//app.MapPut("/api/users", (ClassUsers userData) =>
//{

//    // получаем пользовател€ по id
//    var user = users.FirstOrDefault(u => u.Id == userData.Id);
//    // если не найден, отправл€ем статусный код и сообщение об ошибке
//    if (user == null) return Results.NotFound(new { message = "ѕользователь не найден" });
//    // если пользователь найден, измен€ем его данные и отправл€ем обратно клиенту

//    user.Username = userData.Username;
//    user.Login = userData.Login;
//    user.Password = userData.Password;
//    return Results.Json(user);
//});



//app.Run();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// добавл€ем поддержку контроллеров, которые располагаютс€ в области
app.MapControllerRoute(
    name: "Users",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Chat",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// добавл€ем поддержку дл€ контроллеров, которые располагаютс€ вне области
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();