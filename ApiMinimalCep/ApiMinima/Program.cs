
using ApiMinima.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddDbContext<EnderecoDb>(opt => opt.UseInMemoryDatabase("EnderecoList"));  
            builder.Services.AddAuthorization();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();

      
            if (app.Environment.IsDevelopment())
            {
               app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
         

            app.MapGet("/Endereco Cep", async () => 
            await new HttpClient().GetStringAsync("https://viacep.com.br/ws/01001000/json/"));

            app.MapPost("/Inserir endereco", async (Endereco endereco, EnderecoDb db) =>
            {
                db.Enderecos.Add(endereco);
                await db.SaveChangesAsync();

                return Results.Created($"/enderecoitems/{endereco}", endereco);
            });


            app.UseSwaggerUI();

            await  app.RunAsync();
            
        
         
        

