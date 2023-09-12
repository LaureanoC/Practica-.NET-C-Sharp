using api.Data;
using DominioAlumno;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniversidadContext>(); 
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen(); 


var app = builder.Build();

app.UseSwagger(); 
app.UseSwaggerUI();


//Add
app.MapPost("/alumnos", async (Alumno alumno, UniversidadContext context) =>
{
    context.Alumnos.Add(alumno);
    await context.SaveChangesAsync();

    return Results.Created($"/alumnos/{alumno.Id}", alumno);
});

//GetAll

app.MapGet("/alumnos", async (UniversidadContext context) =>
{
   var alu =  await context.Alumnos.ToListAsync();

    return Results.Ok(alu);

   
});

//Get

app.MapGet("/alumnos/{id}", async (int id, UniversidadContext context) =>
    await context.Alumnos.FindAsync(id) is Alumno alumno
        ? Results.Ok(alumno)
        : Results.NotFound());

//Edit

app.MapPut("/alumnos/{id}", async (int id, Alumno alu, UniversidadContext context) =>
{
    var alumno = await context.Alumnos.FindAsync(id);

    if (alumno is null) return Results.NotFound();

    alumno.Nombre = alu.Nombre;
    alumno.Apellido = alu.Apellido;
    alumno.Direccion = alu.Direccion;
    alumno.Legajo = alu.Legajo;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

//Delete
app.MapDelete("/alumnos/{id}", async (int id, UniversidadContext context) =>
{
    if (await context.Alumnos.FindAsync(id) is Alumno alumno)
    {
        context.Remove(alumno);
        await context.SaveChangesAsync();
        return Results.Ok(alumno);
    }
    else
    {
        return Results.NotFound();
    }
});

app.Run();
