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
//    // �������� ������������ �� id
//    ClassUsers? user = users.FirstOrDefault(x => x.Id == id);
//    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });

//    // ���� ������������ ������, ���������� ���
//    return Results.Json(user);
//});

//app.MapDelete("/api/users/{id}", (string id) =>
//{
//    // �������� ������������ �� id
//    ClassUsers? user = users.FirstOrDefault(x => x.Id == id);

//    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });

//    // ���� ������������ ������, ������� ���
//    users.Remove(user);
//    return Results.Json(user);
//});

//app.MapPost("/api/users", (ClassUsers user) =>
//{

//    // ������������� id ��� ������ ������������
//    user.Id = Guid.NewGuid().ToString();
//    // ��������� ������������ � ������
//    users.Add(user);
//    return user;
//});

//app.MapPut("/api/users", (ClassUsers userData) =>
//{

//    // �������� ������������ �� id
//    var user = users.FirstOrDefault(u => u.Id == userData.Id);
//    // ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//    if (user == null) return Results.NotFound(new { message = "������������ �� ������" });
//    // ���� ������������ ������, �������� ��� ������ � ���������� ������� �������

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

// ��������� ��������� ������������, ������� ������������� � �������
app.MapControllerRoute(
    name: "Users",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Chat",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

// ��������� ��������� ��� ������������, ������� ������������� ��� �������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();