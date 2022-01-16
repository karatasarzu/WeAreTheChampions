using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    public class Player
    {
        public Player()
        {
            PhotoPath = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "defaultimage.png";
        }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string PhotoPath { get; set; }
        [ForeignKey("Team")]
        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
