using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ClinicSystem.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClinicSystemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClinicSystemContext>>()))
            {
                // Look for any movies.
                if (context.Patient.Any())
                {
                    return;   // DB has been seeded
                }

                context.Patient.AddRange(
                    new Patient
                    {
                        Iin = "111111111111",
                        FName = "Dauren",
                        LName = "Dossymbek",
                        Address = "18 Syganak str.",
                        Phone = "7751111111",
                        District = "Essyl"
                    },
                     new Patient
                     {
                         Iin = "222222222222",
                         FName = "Almazhai",
                         LName = "Ageleuova",
                         Address = "18 Syganak str.",
                         Phone = "7752222222",
                         District = "Almaty"
                     },
                     new Patient
                     {
                         Iin = "333333333333",
                         FName = "Sabrina",
                         LName = "Marat",
                         Address = "18 Syganak str.",
                         Phone = "7753333333",
                         District = "Sary-Arka"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
