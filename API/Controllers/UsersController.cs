using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]//endpint هذا الكلاس يعني كنترولر

[Route("api/[controller]")]
//الرابط للكنترولر 
//api/[controller] الكنترولر اسمه يوزرز
public class UsersController(DataContext context) : ControllerBase//عمليه حقن البيانات من الداتا بيس في الكنترولر
{

    [HttpGet]//اجيب بيانات من الداتا بيس 
public async Task<ActionResult <IEnumerable<AppUser>>> GetUsers()//بدنا نرجع كل اليوزرس ليس فقط يوزر واحد
{
    var users = await context.User.ToListAsync();//استعلام عن كل الموجود بالجدول

    return users; //
}

[HttpGet("{id:int}")]
public async Task< ActionResult <AppUser> >GetUser(int id)//app user اسم entitey 
{
    var user =  await context.User.FindAsync(id);
    
    if(user == null) return NotFound();
    
    return user; //هان بيرجع username لم اطلب ايدي معين 
}
}
