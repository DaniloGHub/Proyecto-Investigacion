using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigacion.Shared.Entities
{
    public class ProyectInvest
    {
        [Required(ErrorMessage = "El ID es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del proyecto es obligatorio")]
        public string Name { get; set; } = null;

        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "La fecha de finalización es obligatoria")]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "El nobre del lider es obligatorio")]
        public string Leader { get; set; } = null;

        [Required(ErrorMessage = "La descripción del proyecto es obligatoria")]
        public string Description { get; set; } = null;

        [Required(ErrorMessage = "El área de investigación es obligatorio")]
        public string Area { get; set; } = null;
    }
}
