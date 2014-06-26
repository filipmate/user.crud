using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.CRUD.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        string ToString();
    }
}