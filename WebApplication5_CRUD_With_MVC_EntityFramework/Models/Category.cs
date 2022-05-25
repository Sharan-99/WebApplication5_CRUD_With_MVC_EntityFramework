using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5_CRUD_With_MVC_EntityFramework.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required,StringLength(20,MinimumLength =3)]
        public string Name { get; set; }
    }
}