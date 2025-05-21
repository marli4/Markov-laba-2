using Markov_laba_2.Data;
using Markov_laba_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Markov_laba_2Context(
            serviceProvider.GetRequiredService<
                DbContextOptions<Markov_laba_2Context>>()))
        {
            // Look for any movies.
            if (!(context.Client.Any()))
            {
                context.Client.AddRange(
                    new Client
                    {
                        Login = "aoaoao",
                        Password = "12345"
                    },
                    new Client
                    {
                        Login = "zvzvzv",
                        Password = "qwerty123"
                    }
                );   // DB has been seeded
            }

            if (!(context.Restaurant.Any()))
            {
                context.Restaurant.AddRange(
                    new Restaurant
                    {
                        Name = "Додо пицца"
                    },
                    new Restaurant
                    {
                        Name = "Шаурмен"
                    }
                );   // DB has been seeded
            }
            if (!(context.Courier.Any()))
            {
                context.Courier.AddRange(
                    new Courier
                    {
                        Login = "sanyakiller1488",
                        Password = "alex2007",
                        Name = "Александр",
                        Surname = "Пенской"
                    },
                    new Courier
                    {
                        Login = "amirpro2006",
                        Password = "password",
                        Name = "Амир",
                        Surname = "Ахмедулин"
                    }
                );  // DB has been seeded
            }
            context.SaveChanges();
        }
    }
}

