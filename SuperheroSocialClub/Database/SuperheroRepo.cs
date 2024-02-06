﻿using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Database;

public static class SuperheroRepo
{
    public static List<Superhero> Superheroes { get; set; } = new()
        {
            new Superhero
            {
                Id = 1,
                Name = "Superman",
                SecretIdentity = "Clark Kent",
                Superpowers = new List<string> { "Flight", "Super Strength", "Heat Vision" },
                Image = "1.jpeg"
            },
            new Superhero
            {
                Id = 2,
                Name = "Batman",
                SecretIdentity = "Bruce Wayne",
                Superpowers = new List<string> { "Intelligence", "Martial Arts", "Gadgetry" },
                Image = "2.jpeg"
            },
            new Superhero
            {
                Id = 3,
                Name = "Spider-Man",
                SecretIdentity = "Peter Parker",
                Superpowers = new List<string> { "Wall-Crawling", "Spider-Sense", "Super Agility" },
                Image = "3.jpeg"
            },
            new Superhero
            {
                Id = 4,
                Name = "Wonder Woman",
                SecretIdentity = "Diana Prince",
                Superpowers = new List<string> { "Super Strength", "Lasso of Truth", "Flight" },
                Image = "4.jpeg"
            },
            new Superhero
            {
                Id = 5,
                Name = "Iron Man",
                SecretIdentity = "Tony Stark",
                Superpowers = new List<string> { "Powered Armor", "Genius-level Intellect", "Flight" },
                Image = "5.jpeg"
            },
            new Superhero
            {
                Id = 6,
                Name = "Thor",
                SecretIdentity = "Thor Odinson",
                Superpowers = new List<string> { "God-like Strength", "Control over Lightning", "Mjolnir" },
                Image = "6.jpeg"
            },
            new Superhero
            {
                Id = 7,
                Name = "Hulk",
                SecretIdentity = "Bruce Banner",
                Superpowers = new List<string> { "Superhuman Strength", "Regenerative Healing", "Gamma Radiation" },
                Image = "7.jpeg"
            },
            new Superhero
            {
                Id = 8,
                Name = "Captain America",
                SecretIdentity = "Steve Rogers",
                Superpowers = new List<string> { "Superhuman Strength", "Shield Mastery", "Enhanced Agility" },
                Image = "8.jpeg"
            },
            new Superhero
            {
                Id = 9,
                Name = "Black Widow",
                SecretIdentity = "Natasha Romanoff",
                Superpowers = new List<string> { "Expert Martial Artist", "Espionage Skills", "Master Marksman" },
                Image = "9.jpeg"
            },
            new Superhero
            {
                Id = 10,
                Name = "Green Lantern",
                SecretIdentity = "Hal Jordan",
                Superpowers = new List<string> { "Power Ring", "Flight", "Energy Projection" },
                Image = "10.jpeg"
            },
            new Superhero
            {
                Id = 11,
                Name = "Flash",
                SecretIdentity = "Barry Allen",
                Superpowers = new List<string> { "Super Speed", "Time Travel", "Speed Force Connection" },
                Image = "11.jpeg"
            },
            new Superhero
            {
                Id = 12,
                Name = "Aquaman",
                SecretIdentity = "Arthur Curry",
                Superpowers = new List<string> { "Super Strength", "Control over Sea Life", "Underwater Adaptation" },
                Image = "12.jpeg"
            },
            new Superhero
            {
                Id = 13,
                Name = "Doctor Strange",
                SecretIdentity = "Stephen Strange",
                Superpowers = new List<string> { "Mystical Arts", "Time Manipulation", "Dimensional Travel" },
                Image = "13.jpeg"
            },
            new Superhero
            {
                Id = 14,
                Name = "Ant-Man",
                SecretIdentity = "Scott Lang",
                Superpowers = new List<string> { "Size Manipulation", "Control over Ants", "Master Thief" },
                Image = "14.jpeg"
            },

            new Superhero
            {
                Id = 15,
                Name = "Black Panther",
                SecretIdentity = "T'Challa",
                Superpowers = new List<string> { "Superhuman Strength", "Enhanced Senses", "Vibranium Suit" },
                Image = "15.jpeg"
            }
        };
}
