﻿using EasyAbp.AbpHelper.Attributes;

namespace EasyAbp.AbpHelper.Commands.Ef.Migrations.Add
{
    public class AddCommandOption : MigrationsCommandOption
    {
        [Argument("name", Description = "The name of the migration.")]
        public string Name { get; set; } = null!;

        [Argument("ef-options", Description = "Other options to `dotnet ef migrations add`")]
        public string[] EfOptions { get; set; } = {};
    }
}