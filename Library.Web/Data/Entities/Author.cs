﻿using System.ComponentModel.DataAnnotations; // Importa el espacio de nombres que contiene las clases para validación de datos.

namespace Library.Web.Data.Entities
{
    // Clase que representa la entidad Autor en la base de datos.
    public class Author
    {   //para especificar la longitud máxima permitida 
        // Propiedad que representa el identificador del autor.
        [MaxLength(128, ErrorMessage = "El campo {0} debe tener al menos un caracter.")]
        public int Id { get; set; }

        // Propiedad que representa el nombre del autor.
        [MaxLength(128, ErrorMessage = "El campo {0} debe tener al menos un caracter.")]
        public string Name { get; set; }

        // Propiedad que representa el apellido del autor.
        [MaxLength(128, ErrorMessage = "El campo {0} debe tener al menos un caracter.")]
        public string Last_Name { get; set; }
    }
}