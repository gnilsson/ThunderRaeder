using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ThunderRaeder.Data.Entities;
using ThunderRaeder.Shared.Enums;
using Bogus.DataSets;

namespace ThunderRaeder.Data.Seed
{
    public static class DatabaseSeeder
    {
        public static void Run(ModelBuilder modelBuilder)
        {
            var titles = ReadBookTitlesFromFile();
            Randomizer.Seed = new Random(858586);

            var testAuthors = new Faker<Author>("sv")
                .RuleFor(a => a.Id, f => Guid.NewGuid())
                .RuleFor(a => a.Gender, f => f.PickRandom<Gender>())
                .RuleFor(a => a.Firstname, (f, a) => f.Name.FirstName((Name.Gender)a.Gender))
                .RuleFor(a => a.Lastname, (f, a) => f.Name.LastName((Name.Gender)a.Gender));

            var authors = testAuthors.Generate(50);

            var testBooks = new Faker<Book>()
                .RuleFor(o => o.Id, f => Guid.NewGuid())
                .RuleFor(o => o.Description, f => f.Lorem.Paragraph())
                .RuleFor(o => o.Genre, f => f.PickRandom<Genre>())
                .RuleFor(o => o.Title, f => f.PickRandom(titles))
                .RuleFor(o => o.AuthorId, f => f.PickRandom(authors).Id);

            //var hmBooks = new Faker<Book>()
            //    .RuleFor(o => o.Title, f => f.Literature().CommonSense());

            var books = testBooks.Generate(100);

            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<Book>().HasData(books);
        }

        public static List<string> ReadBookTitlesFromFile()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("API", "Data"), @"JsonData\booktitles.json");
            var titles = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(filePath));
            return titles;
        }
    }
}
